
using AutoMapper;


using Microsoft.Extensions.Configuration;
using wazyApi.Dtos;
using wazyApi.Models;

namespace API.Helpers {
    public class SmPictureUrlResolver : IValueResolver<SmPicture, SmPicture, string> {
        private readonly IConfiguration  _config ;

        public SmPictureUrlResolver (IConfiguration config) {
                 _config = config;
        }
      
 
  

        public string Resolve (SmPicture source, SmPicture destination, string destMember, ResolutionContext context) {
            if (!string.IsNullOrEmpty (source.url)) {
                return _config["ApiUrl"] + source.url +".jpg";
            }

            return null;
        }
    }
}