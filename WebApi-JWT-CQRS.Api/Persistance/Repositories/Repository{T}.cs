using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebApi_JWT_CQRS.Api.Core.Application.Interfaces;
using WebApi_JWT_CQRS.Api.Persistance.Context;

namespace WebApi_JWT_CQRS.Api.Persistance.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly JwtCqrsContext _jwtCqrsContext;

        public Repository( JwtCqrsContext jwtCqrsContext)
        {
            this._jwtCqrsContext = jwtCqrsContext;
        }
        public async Task CreateAsync(T entity)
        {
            await this._jwtCqrsContext.Set<T>().AddAsync(entity);
            await this._jwtCqrsContext.SaveChangesAsync();
        }


        public async Task<List<T>> GetAllAsync()
        {
            return await this._jwtCqrsContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T?> GetByFilterAsync(Expression<Func<T, bool>> filter)
        {
            return await this._jwtCqrsContext.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter);
        }

        public async Task<T?> GetByIdAsync(object id)
        {
            return await this._jwtCqrsContext.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            this._jwtCqrsContext.Set<T>().Update(entity);
            await this._jwtCqrsContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            this._jwtCqrsContext.Set<T>().Remove(entity);
            await this._jwtCqrsContext.SaveChangesAsync();
        }
    }
}
