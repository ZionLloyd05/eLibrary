using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.ApplicationCore.Interfaces
{
    public interface IAsyncRepository<T> where T : class, IAggregateRoot
    {
        Task<T> GetByIdAsync(int? id);
        Task<IEnumerable<T>> ListAllAsync();
        Task<IEnumerable<T>> ListAsync(ISpecification<T> spec);
        Task<T> GetByIdAsync(ISpecification<T> spec);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<int> CountAsync(ISpecification<T> spec);
    }
}
