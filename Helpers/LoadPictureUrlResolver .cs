
using AutoMapper;


using Microsoft.Extensions.Configuration;
using wazyApi.Dtos;
using wazyApi.Models;

namespace API.Helpers
{
    public class LoadPictureUrlResolver : IValueResolver<PictureDto, PictureDto, string>
    {
        private readonly IConfiguration _config;
        private readonly IWebHostEnvironment hoting;

        public LoadPictureUrlResolver(IConfiguration config, IWebHostEnvironment hoting)
        {
            this.hoting = hoting;
            _config = config;
        }




        public string Resolve(PictureDto source, PictureDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.url))
            {
                return UplaodFile(source.ImageFile);
            }

            return null;
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


    }
}