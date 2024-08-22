using MediatR;
using WebApi_JWT_CQRS.Api.Core.Application.Features.CQRS.Commands;
using WebApi_JWT_CQRS.Api.Core.Application.Interfaces;
using WebApi_JWT_CQRS.Api.Core.Domain;

namespace WebApi_JWT_CQRS.Api.Core.Application.Features.CQRS.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, Unit>
    {

        private readonly IRepository<Product> repository;
        public CreateProductCommandHandler(IRepository<Product> repository)
        {
            this.repository = repository;
        }
        public async Task<Unit> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            await this.repository.CreateAsync( new Product
            {
                CategoryId = request.CategoryId,
                Name = request.Name,
                Price = request.Price,
                Stock = request.Stock
            });
            return Unit.Value;
        }
    }
}
