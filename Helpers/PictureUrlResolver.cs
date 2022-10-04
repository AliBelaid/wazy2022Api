
using AutoMapper;


using Microsoft.Extensions.Configuration;
using wazyApi.Dtos;
using wazyApi.Models;

namespace API.Helpers {
    public class PictureUrlResolver : IValueResolver<Picture, Picture, string> {
        private readonly IConfiguration  _config ;

        public PictureUrlResolver (IConfiguration config) {
                 _config = config;
        }
      
 
  

        public string Resolve (Picture source, Picture destination, string destMember, ResolutionContext context) {
            if (!string.IsNullOrEmpty (source.url)) {
                return _config["ApiUrl"] + source.url +".jpg";
            }

            return null;
        }
    }
}