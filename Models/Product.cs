using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using wazyApi.Models;
namespace wazyApi.Models
{
    public partial class Product  : BaseEntity
    {
      
        public string? Name { get; set; }
        public string? Code { get; set; } 
        public string? ShortDesc { get; set; }
        public string? LongDesc { get; set; }
        public string? Manufacturer { get; set; }
        public decimal SalePrice { get; set; }
        public int AvQty { get; set; }
        public int? VendorId { get; set; }
        public int? Rating { get; set; }
        public int? Reviews { get; set; }
 
        public string? OnlineStatus { get; set; }
        public string? HasComment { get; set; }
        public int IsNew { get; set; }
        public int IsSale { get; set; }
        public string? slug { get; set; }="yikto";
        public string? RefField { get; set; }
        public DateTime? Until { get; set; } = DateTime.Now;
        public int? Stock { get; set; }
        public int? Top { get; set; }
        public bool? Featured { get; set; }
        public int? New { get; set; }
        public string? Author { get; set; } ="author";
        public bool? Sold { get; set; } 
           public List<Category> category { get; set; }= new List<Category>();
        public List<Brand> brands { get; set; }= new List<Brand>();
        public List<Picture> pictures { get; set; }= new List<Picture>();
        public List<SmPicture> sm_pictures { get; set; }= new List<SmPicture>();
        public List<Variant> variants { get; set; } = new List<Variant>();
    }
 
          public class Blog:BaseEntity
    {
         public string author { get; set; }=string.Empty;
        public string comments { get; set; }=string.Empty;
        public string content { get; set; }=string.Empty;
        public string date { get; set; }=string.Empty;
        public string? slug { get; set; }=string.Empty;
        public string title { get; set; }=string.Empty;
        public string type { get; set; }=string.Empty;
        public List<BlogCategory> blog_categories { get; set; }}
      
    public class BlogCategory:BaseEntity
    {
        public string name { get; set; }=string.Empty;
        public string? slug { get; set; }=string.Empty;
     }

    public class Brand:BaseEntity
    {
        public string name { get; set; }=string.Empty;
        public string? slug { get; set; }=string.Empty;
        
    }

    public class Category:BaseEntity
    {
        public string name { get; set; }=string.Empty;
        public string? slug { get; set; }=string.Empty;
        
    }

    public class Picture:BaseEntity
    {
        public string width { get; set; }=string.Empty;
        public string height { get; set; }=string.Empty;
        public string url { get; set; }=string.Empty;
        
    }

  
    public class Pivot:BaseEntity
    {
        public string product_id { get; set; }=string.Empty;
         [JsonProperty(PropertyName = "Product-Category_Id")]
         public string ProductCategoryId { get; set; } =string.Empty;
        public string brand_id { get; set; }=string.Empty;

        public string related_id { get; set; }=string.Empty;
        public string upload_file_id { get; set; }=string.Empty;
        public string blog_id { get; set; }=string.Empty;
         public string BlogCategoryId { get; set; }=string.Empty;
    }

  
     
    // public class Root
    // {
    //     public List<Product> products { get; set; }
    //     public List<Blog> blogs { get; set; }
    // }

    public class SmPicture:BaseEntity
    {
        public string width { get; set; }=string.Empty;
        public string height { get; set; }=string.Empty;
        public string url { get; set; }=string.Empty;
      
    }
 
       public class Size:BaseEntity
    {
         public string name { get; set; }=string.Empty;
        public string? slug { get; set; }=string.Empty;
       
    }

        public class SizeDto:BaseEntity
    {
         public string name { get; set; }=string.Empty;
        public string? slug { get; set; }=string.Empty;
        
    }

    public class Variant:BaseEntity
    {
         public string color { get; set; }=string.Empty;
        public string color_name { get; set; }=string.Empty;
        public double price { get; set; }=0;
       
        public List<Size> size { get; set; }
    }

}