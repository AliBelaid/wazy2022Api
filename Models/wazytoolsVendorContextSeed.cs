// using System;
// using System.Collections.Generic;
// using System.IO;
// using System.Linq;
// using System.Text.Json;
// using System.Threading.Tasks;
// using AutoMapper;
// using Microsoft.Extensions.Logging;

// namespace wazyApi.Models {
//     public class wazytoolsVendorContextSeed {
 
     
//         public static async Task SeedAsync (wazytools_vendorContext context,IMapper mapper) {
//                  if (!context.ProductDtos.Any() ) {
//                     var brander = File.ReadAllText ("../wazyApi/Models/prod.json");
//                     var items = JsonSerializer.Deserialize<List<ProductDto>> (brander);
//                     foreach (var item in items) {

//                                  context.ProductDtos.Add (item);
//                     }
//                     await context.SaveChangesAsync ();
//                 }
              
//              if (!context.Blogs.Any()  ) {
//                     var brander = File.ReadAllText ("../wazyApi/Models/blog.json");
//                     var items = JsonSerializer.Deserialize<List<Blog>> (brander);
//                     foreach (var item in items) {

//                                  context.Blogs.Add (item);
//                     }
//                     await context.SaveChangesAsync ();
//                 }
              
 
//         }
//     }
// }