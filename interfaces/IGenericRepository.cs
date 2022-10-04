using System.Collections.Generic;
using System.Threading.Tasks;
using wazyApi.Models;
using wazyApi.Specifications;

namespace wazyApi.interfaces {
    public interface IGenericRepository<T> where T : BaseEntity {

      Task<T> GetByIdAsync (int id);
        Task<IReadOnlyList<T>> ListAllAsync ();
        Task<T> GetEntityWithSpec (ISpecifications<T> spec);
        Task<IReadOnlyList<T>> ListAsync (ISpecifications<T> spec);
        Task<int> CountAsync (ISpecifications<T> spec);
        void Add (T entity);
        void Update (T entity);
        void Delete (T entity);

        Task<bool> Save();
    }
}