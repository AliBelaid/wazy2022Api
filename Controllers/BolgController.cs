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
using wazyApi.interfaces;
using wazyApi.Models;

namespace wazyApi.Controllers
{

    public class BolgController : BaseController
    {
        private readonly IGenericRepository<Blog> repoBlog;
        private readonly IMapper mapper;

        public BolgController(IGenericRepository<Blog> repoBlog, IMapper mapper)
        {
            this.repoBlog = repoBlog;

            this.mapper = mapper;

        }

        [HttpGet()]
        public async Task<ActionResult<IReadOnlyList<Blog>>> GetBlogs()
        {
            //    var data = _mapper.Map<IReadOnlyList<Product>,IReadOnlyList<ProductToReturnDto>>(products);
            return Ok(await repoBlog.ListAllAsync());
        }

        [HttpGet("{id}")]
        [ProducesResponseType((StatusCodes.Status200OK))]

        public async Task<ActionResult<Blog>> GetBlog(int id)
        {


            var blog = await repoBlog.GetByIdAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            return Ok((blog));

        }

       
      [HttpPost]
        public async Task<ActionResult<Brand>> CreateBlog (Blog BlogDto) {
           
              repoBlog.Add(BlogDto);
      
           var result= await repoBlog.Save();
            if (!result) return BadRequest ("Problam createing order");
            return Ok (BlogDto);

        }

    }
}