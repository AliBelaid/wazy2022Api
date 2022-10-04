using System.Linq;

using Core.Specifications;
using Microsoft.EntityFrameworkCore;
using wazyApi.Models;

namespace wazyApi.Specifications
{
    public class SpecificationEvaluator<TEntity> where TEntity: BaseEntity
    {
        public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuey ,ISpecifications<TEntity> spec) {
         var query= inputQuey;

        if(spec.Criteria !=null) {
            query = query.Where(spec.Criteria);

        }
     if(spec.OrderBy!=null) {
         query = query.OrderBy(spec.OrderBy);
     }

     if(spec.IsPagingEnabled) {
         query =query.Skip(spec.Skip).Take(spec.Take);
     }
   if(spec.OrderByDescding!=null) {
         query = query.OrderByDescending(spec.OrderByDescding);
     }

            query = spec.Includes.Aggregate(query,(current,include)=> current.Include(include));
      return query;


        }
    }
}