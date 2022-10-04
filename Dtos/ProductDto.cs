namespace wazyApi.Dtos
{
    public class ProductDto
    {
              
        public string Name { get; set; }
        public string Code { get; set; } 
        public string ShortDesc { get; set; }
        public string LongDesc { get; set; }
        public string Manufacturer { get; set; }
        public decimal SalePrice { get; set; }
        public int AvQty { get; set; }
        public int? VendorId { get; set; }
        public int? Rating { get; set; }
        public int? Reviews { get; set; }
 
        public string? OnlineStatus { get; set; }
        public string? HasComment { get; set; }
        public int IsNew { get; set; }
        public int IsSale { get; set; }
        public string? slug { get; set; }
        public string? RefField { get; set; }
        public DateTime? Until { get; set; } =DateTime.Now;
        public int? Stock { get; set; }
        public int? Top { get; set; }
        public bool? Featured { get; set; }
        public int? New { get; set; }
        public string? Author { get; set; } ="author";
        public bool? Sold { get; set; } 
           public List<CategoryDto> category { get; set; }
        public List<BrandDto> brands { get; set; }
        public List<PictureDto>? pictures { get; set; }
        public List<PictureDto>? sm_pictures { get; set; }
        public List<VariantDto> variants { get; set; }
    }}