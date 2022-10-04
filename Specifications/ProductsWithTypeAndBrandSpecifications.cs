

using wazyApi.Models;
using wazyApi.Specifications;

namespace wazyApi.Specifications {
    public class ProductsWithTypeAndBrandSpecifications : BaseSpecifications<Product> {
        public ProductsWithTypeAndBrandSpecifications(ProductSpecParams productParams)
        //  && (string.IsNullOrEmpty(productParams.Search) || x.name.ToLower().Contains(productParams.Search))
         
            {
            AddInclude(x => x.brands);
            AddInclude(x => x.category);
             AddInclude(x => x.variants);
                       AddInclude(x => x.sm_pictures);
                          AddInclude(x => x.pictures);
            AddOrderBy(x=>x.Name);
                            ApplayPaging(productParams.PageSize*(productParams.PageIndex-1),productParams.PageSize);

            // if(!string.IsNullOrEmpty(productParams.sort)){

            //     switch(productParams.sort) {
            //         case "priceAsc":
            //         AddOrderBy(p=>p.sale_price);
            //         break;
            //          case "priceDesc":
            //         AddOrderByDescending(p=>p.sale_price);
            //         break;
            //         default:
            //         AddOrderBy(x=>x.name);
            //         break;
            //     }
            // }

        }

        public ProductsWithTypeAndBrandSpecifications (int id) : base (x => x.id == id) {
            AddInclude (x => x.category);
            AddInclude (x => x.brands);  
              AddInclude(x => x.variants);
       
        }
    }
}