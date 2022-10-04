namespace wazyApi.Dtos
{
    public class VariantDto
    {
          public string color { get; set; }
        public string color_name { get; set; }
        public int price { get; set; }
        
        public List<SizeDto> size { get; set; }
    }
}