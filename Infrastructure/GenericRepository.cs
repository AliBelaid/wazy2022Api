using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using wazyApi.interfaces;
using wazyApi.Models;
using wazyApi.Specifications;

namespace wazyApi.Infrastructure {
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity {
        private readonly wazytools_vendorContext _ctx;
        private readonly IMapper _mapper;

        public GenericRepository (wazytools_vendorContext ctx,IMapper mapper) {
            _ctx = ctx;
            _mapper = mapper;
        }

               async Task<T> IGenericRepository<T>.GetByIdAsync (int id) {
            return await _ctx.Set<T>().FindAsync(id);

        }

        async Task<IReadOnlyList<T>> IGenericRepository<T>.ListAllAsync () {
            return await _ctx.Set<T>().ToListAsync ();
        }

        async Task<IReadOnlyList<T>> IGenericRepository<T>.ListAsync (ISpecifications<T> spec) {
            return await applaySpecification (spec).ToListAsync ();
        }
        async Task<T> IGenericRepository<T>.GetEntityWithSpec (ISpecifications<T> spec) {
            return await applaySpecification (spec).FirstOrDefaultAsync ();
        }
        private IQueryable<T> applaySpecification (ISpecifications<T> spec) {
            return SpecificationEvaluator<T>.GetQuery (_ctx.Set<T> ().AsQueryable (), spec);
        }

        public async Task<int> CountAsync (ISpecifications<T> spec) {
            return await applaySpecification (spec).CountAsync ();
        }

        public void Add(T entity)
        {
           _ctx.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
        _ctx.Set<T>().Attach(entity);
        _ctx.Entry(entity).State = EntityState.Modified;

        }

        public void Delete(T entity)
        {
            _ctx.Set<T>().Remove(entity);
        }

        public async Task<bool> Save()
        {
           return await             _ctx.SaveChangesAsync()>1;

        }
    }
}