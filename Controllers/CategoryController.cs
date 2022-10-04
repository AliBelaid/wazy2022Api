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
 
    public class CategoryController : BaseController {
        private readonly IGenericRepository<Product> repoProduct;
        private readonly IMapper mapper;
        private readonly IGenericRepository<Brand> repProductBrand;
        private readonly IGenericRepository<Category> repoProductCategory;
   

        public CategoryController (IGenericRepository<Product> repoProduct , IMapper mapper,
         IGenericRepository<Brand> repProductBrand ,
        IGenericRepository<Category>repoProductCategory ) {
            this.repoProduct = repoProduct;
            this.mapper = mapper;
            this.repProductBrand = repProductBrand;
            this.repoProductCategory = repoProductCategory;
            
        }
 
          [HttpGet("types")]
        public async Task<ActionResult<List<Category>>> GetProductType () {

           
          
            return Ok(await repoProductCategory.ListAllAsync()) ;
         }
         [HttpPost]
        public async Task<ActionResult<Brand>> CreateTypr (Category CategoryDto) {
           
              repoProductCategory.Add(CategoryDto);
      
           var result= await repoProductCategory.Save();
            if (!result) return BadRequest ("Problam createing order");
            return Ok (CategoryDto);

        }
[HttpDelete]
        [ProducesResponseType((StatusCodes.Status200OK))]
        [ProducesResponseType(typeof(ApiResponse), (StatusCodes.Status404NotFound))]

        public async Task<ActionResult> DeleteCatgoryt(int id)
        {

          
            var cat = await repoProductCategory.GetByIdAsync(id);
           
            if (cat == null)
            {
                return NotFound(new ApiResponse(404));
            }
          
              repoProductCategory.Delete(cat);
              if(!await repoProduct.Save())
               {  return BadRequest(new ApiResponse(403));}

           return Ok();    
        }
    }

  
    
}