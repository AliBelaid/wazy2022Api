using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using wazyApi.Errors;
using wazyApi.interfaces;
using wazyApi.Models;

namespace wazyApi.Controllers {
 
    public class BrandController : BaseController {
        private readonly IGenericRepository<Product> repoProduct;
        private readonly IMapper mapper;
        private readonly IGenericRepository<Brand> repProductBrand;
        private readonly IGenericRepository<Category> repoProductCategory;
   

        public BrandController (IGenericRepository<Product> repoProduct , IMapper mapper,
         IGenericRepository<Brand> repProductBrand ,
        IGenericRepository<Category>repoProductCategory ) {
            this.repoProduct = repoProduct;
            this.mapper = mapper;
            this.repProductBrand = repProductBrand;
            this.repoProductCategory = repoProductCategory;
            
        }

       

        [HttpGet ("{id}")]
        [ProducesResponseType((StatusCodes.Status200OK))]
 
        public async Task<ActionResult<Brand>> GetBrand(int id) {

           
            var product = await repoProduct.GetByIdAsync(id);
            if(product==null) {
              return NotFound();
            }
            return  Ok((product)); 
     
        }

         [HttpGet("brands")]
        public async Task<ActionResult<List<Brand>>> GetProductBrand () {
           

          return Ok(await repProductBrand.ListAllAsync()) ;
        }
        
      
          [HttpPost]
        public async Task<ActionResult<Brand>> CreateBrand (Brand brandDto) {
           
              repProductBrand.Add(brandDto);
      
           var result= await repProductBrand.Save();
            if (!result) return BadRequest ("Problam createing order");
            return Ok (brandDto);

        }

  [HttpDelete]
 
        [ProducesResponseType((StatusCodes.Status200OK))]
        [ProducesResponseType(typeof(ApiResponse), (StatusCodes.Status404NotFound))]

        public async Task<ActionResult> DeleteBrand(int id)
        {

          
            var cat = await repProductBrand.GetByIdAsync(id);
           
            if (cat == null)
            {
                return NotFound(new ApiResponse(404));
            }
          
              repProductBrand.Delete(cat);
              if(!await repoProduct.Save())
              {  return BadRequest(new ApiResponse(403));}

           return Ok();    
        }
    }
}