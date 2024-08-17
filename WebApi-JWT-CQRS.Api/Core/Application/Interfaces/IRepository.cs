using System.Linq.Expressions;

namespace WebApi_JWT_CQRS.Api.Core.Application.Interfaces
{
    public interface IRepository<T> where T : class, new()
    {
        Task<List<T>> GetAllAsync();
        Task<T?> GetByIdAsync(object id);
        Task<T?> GetByFilterAsync(Expression<Func<T,bool>> filter);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
