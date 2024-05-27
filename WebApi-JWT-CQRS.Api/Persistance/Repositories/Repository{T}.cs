using WebApi_JWT_CQRS.Api.Core.Application.Interfaces;

namespace WebApi_JWT_CQRS.Api.Persistance.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {

    }
}
