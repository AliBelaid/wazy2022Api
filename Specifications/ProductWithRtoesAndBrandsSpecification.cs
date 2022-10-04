
using wazyApi.Models;
using wazyApi.Specifications;

namespace Core.Specifications
{
    public class ProductWithFiltersForCountSpecification :BaseSpecifications<Product>
    {
        public ProductWithFiltersForCountSpecification(ProductSpecParams productParams) 
        // :  
        //  base(x=> ((!productParams.BrandId.HasValue || x.brands.Any(i=>i.id==productParams.BrandId)) &&
        //  (!productParams.TypeId.HasValue || x.category.Any(i=>i.id==productParams.TypeId))
 
      //    && (string.IsNullOrEmpty(productParams.Search) || x.name.ToLower().Contains(productParams.Search))
  
         
          {
          
         }}
}

