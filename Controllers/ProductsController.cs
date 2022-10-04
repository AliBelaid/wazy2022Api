using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Core.Specifications;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using Microsoft.Net.Http.Headers;
using wazyApi.Dtos;
using wazyApi.Errors;
using wazyApi.Helpers;
using wazyApi.interfaces;
using wazyApi.Models;
using wazyApi.Specifications;

namespace wazyApi.Controllers
{

    public class ProductsController : BaseController
    {
        private readonly IGenericRepository<Product> repoProduct;
        private readonly IMapper mapper;

        private readonly IWebHostEnvironment hoting;

        public ProductsController(IGenericRepository<Product> repoProduct, IWebHostEnvironment hoting, IMapper mapper)
        {
            this.hoting = hoting;
            this.repoProduct = repoProduct;
            this.mapper = mapper;


        }

        [HttpGet("products")]
        public async Task<ActionResult<IReadOnlyList<Pagination<Product>>>> GetProducts([FromQuery] ProductSpecParams productParams)
        {
            var spec = new ProductsWithTypeAndBrandSpecifications(productParams);

            var countSpec = new ProductWithFiltersForCountSpecification(productParams);
            var totalItems = await repoProduct.CountAsync(countSpec);

            var products = await repoProduct.ListAsync(spec);
            // var data =  mapper.Map<IReadOnlyList<Product>,IReadOnlyList<Product>>(products);
            return Ok(new Pagination<Product>(productParams.PageIndex,
            productParams.PageSize, totalItems, products));
        }
        [HttpGet("productsvvvv")]
        public async Task<ActionResult<IReadOnlyList<Product>>> GetProductsv()
        {

            var products = await repoProduct.ListAllAsync();
            var data = products;// _mapper.Map<IReadOnlyList<Product>,IReadOnlyList<ProductToReturnDto>>(products);
            return Ok(data);
        }

        [HttpGet("{id}")]
        [ProducesResponseType((StatusCodes.Status200OK))]
        [ProducesResponseType(typeof(ApiResponse), (StatusCodes.Status404NotFound))]

        public async Task<ActionResult<ProductDto>> GetProduct(int id)
        {

            var spec = new ProductsWithTypeAndBrandSpecifications(id);
            var product = await repoProduct.GetEntityWithSpec(spec);
            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }
          

            return Ok(mapper.Map<List<Product>>(product));
        }

        [HttpPost()]
        public async Task<ActionResult<ProductDto>> CreateProduct(ProductDto productDto)
        {

            try
            {

                if (productDto.sm_pictures != null)
                {
                    foreach (var imgeSm in productDto.sm_pictures)
                    {
                        imgeSm.url = UplaodFile(imgeSm.ImageFile);
                    }

                }
                if (productDto.pictures != null)
                {
                    foreach (var imge in productDto.pictures)
                    {
                        imge.url = UplaodFile(imge.ImageFile);
                    }
                }
            }
            catch
            {

            }

            var prduct = mapper.Map<Product>(productDto);


            repoProduct.Add(prduct);

            var result = await repoProduct.Save();
            if (!result) return BadRequest("Problam createing order");
            return Ok(productDto);

        }

        [HttpPost("AddSmPicture/{id}")]
        public async Task<ActionResult<Product>> AddSmPicture(IFormFile imageToAdd)
        {

            string height = string.Empty;
            string width = string.Empty;

            var id = int.Parse(Response.HttpContext.GetRouteValue("id").ToString());
            height = Response.HttpContext.GetRouteValue("height").ToString();
            width = Response.HttpContext.GetRouteValue("width").ToString();
            var spec = new ProductsWithTypeAndBrandSpecifications(id);
            var prudct = await repoProduct.GetEntityWithSpec(spec);
            if (prudct == null)
            {
                return NotFound(new ApiResponse(404));
            }
            var url = UplaodFile(imageToAdd);

            prudct.sm_pictures.Add(new SmPicture
            {
                height = string.IsNullOrEmpty(height) ? "400" : height,
                width = string.IsNullOrEmpty(width) ? "400" : width,
                url = url,

            });


            repoProduct.Update(prudct);
            var result = await repoProduct.Save();
            if (!result) return NotFound(new ApiResponse(404));
            return Ok(prudct);

        }

        //     [HttpPut("addBigPicture/{id}")]
        // public async Task<ActionResult<Product>> AddBigPicture(int id,[FromBody]IFormFile imageToAdd)
        // {   var url = UplaodFile(imageToAdd);

        //     var prudct = await repoProduct.GetByIdAsync(id);
        //     if (prudct == null)
        //     {
        //         return NotFound(new ApiResponse(404));
        //     }
        //     prudct.pictures.Add(new Picture
        //     {
        //         height = "400",
        //         width = "400",
        //         url = url,

        //     });
        //     repoProduct.Update(prudct);
        //     var result = await repoProduct.Save();
        //     if (!result) return NotFound(new ApiResponse(404));
        //     return Ok(prudct);

        // }
        [HttpPost("addBigPicture/{id}")]
        public async Task<ActionResult<Product>> addBigPicture(IFormFile imageToAdd)
        {
            string height = string.Empty;
            string width = string.Empty;
            var id = int.Parse(Response.HttpContext.GetRouteValue("id").ToString());
            height = Response.HttpContext.GetRouteValue("height").ToString();
            width = Response.HttpContext.GetRouteValue("width").ToString();

            var spec = new ProductsWithTypeAndBrandSpecifications(id);



            var prudct = await repoProduct.GetEntityWithSpec(spec);
            if (prudct == null)
            {
                return NotFound(new ApiResponse(404));
            }
            var url = UplaodFile(imageToAdd);

            prudct.pictures.Add(new Picture
            {
                height = string.IsNullOrEmpty(height) ? "900" : height,
                width = string.IsNullOrEmpty(width) ? "900" : width,
                url = url,

            });


            repoProduct.Update(prudct);
            var result = await repoProduct.Save();
            if (!result) return NotFound(new ApiResponse(404));
            return Ok(prudct);

        }
        private string UplaodFile(IFormFile file)
        {
            string fileName = null;
            if (file != null)
            {
                string uploadDir = Path.Combine(hoting.WebRootPath, "Upload");
                fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                string filePath = Path.Combine(uploadDir, fileName);
                using (var filrStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(filrStream);
                }

            }
            return fileName;
        }

[HttpDelete]
        [ProducesResponseType((StatusCodes.Status200OK))]
        [ProducesResponseType(typeof(ApiResponse), (StatusCodes.Status404NotFound))]

        public async Task<ActionResult<ProductDto>> DeleteProduct(int id)
        {

            var spec = new ProductsWithTypeAndBrandSpecifications(id);
            var product = await repoProduct.GetEntityWithSpec(spec);
           
            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }
          
              repoProduct.Delete(product);
              if(!await repoProduct.Save())
               {  return BadRequest(new ApiResponse(403));}

           return Ok();    
        }
    }




}