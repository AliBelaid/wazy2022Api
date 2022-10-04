namespace wazyApi.Dtos
{
     public class PictureDto
    {
        public string width { get; set; }
        public string height { get; set; }
        public string? url { get; set; }
         public   IFormFile ImageFile  { get; set; }

    }
}