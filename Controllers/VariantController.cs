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

namespace wazyApi.Controllers
{

    public class VariantController : BaseController
    {
        private readonly IGenericRepository<Size> repoSize;
        private readonly IMapper mapper;

        public IGenericRepository<Size> RepoSize { get; }
        private readonly IGenericRepository<Variant> repoVariant;

        public VariantController(IGenericRepository<Size> repoSize, IMapper mapper, IGenericRepository<Variant> repoVariant)
        {
            this.repoVariant = repoVariant;
            this.RepoSize = repoSize;

            this.mapper = mapper;


        }

        [HttpGet()]
        public async Task<ActionResult<IReadOnlyList<Variant>>> GetVariants()
        {
            //    var data = _mapper.Map<IReadOnlyList<Product>,IReadOnlyList<ProductToReturnDto>>(products);
            return Ok(await repoVariant.ListAllAsync());
        }
        
     
      [HttpGet("{id}")]
        [ProducesResponseType((StatusCodes.Status200OK))]

        public async Task<ActionResult<Variant>> GetVariant(int id)
        {


            var size = await repoVariant.GetByIdAsync(id);
            if (size == null)
            {
                return NotFound();
            }
            return Ok((size));

        }
  
          [HttpPost()]
        public async Task<ActionResult<Variant>> CreateVariant(Variant SizetDto)
        {

            repoVariant.Add(SizetDto);

            var result = await repoVariant.Save();
            if (!result) return BadRequest("Problam createing order");
            return Ok(SizetDto);

        }
        [HttpDelete()]
       
        [ProducesResponseType((StatusCodes.Status200OK))]
        [ProducesResponseType(typeof(ApiResponse), (StatusCodes.Status404NotFound))]

        public async Task<ActionResult> DeleteVariant(int id)
        {


            var cat = await repoVariant.GetByIdAsync(id);

            if (cat == null)
            {
                return NotFound(new ApiResponse(404));
            }

            repoVariant.Delete(cat);
            if (!await repoVariant.Save())
                  {  return BadRequest(new ApiResponse(403));}

           return Ok();    
        }
       
    }
}