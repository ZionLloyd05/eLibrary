using eLibrary.ApplicationCore.Interfaces;
using eLibrary.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using eLibrary.ApplicationCore.Entities;
using System.Linq;

namespace eLibrary.Infrastructure.Repositories
{
    public class LibraryRepository<T> : IAsyncRepository<T> where T : BaseEntity, IAggregateRoot
    {
        private readonly eLibraryContext _ctx;

        public LibraryRepository(eLibraryContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<T> AddAsync(T entity)
        {
            _ctx.Set<T>().Add(entity);
            await _ctx.SaveChangesAsync();

            return entity;
        }

        public async Task<int> CountAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).CountAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _ctx.Set<T>().Remove(entity);
            await _ctx.SaveChangesAsync();
        }

        public async Task<T> GetByIdAsync(int? id)
        {
            return await _ctx.Set<T>().FindAsync(id);
        }

        public async Task<T> GetByIdAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> ListAllAsync()
        {
            return await _ctx.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> ListAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).ToListAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _ctx.Entry(entity).State = EntityState.Modified;
            await _ctx.SaveChangesAsync();
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_ctx.Set<T>().AsQueryable(), spec);
        }

    }
}
