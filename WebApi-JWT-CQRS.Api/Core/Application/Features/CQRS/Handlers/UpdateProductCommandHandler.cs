using MediatR;
using WebApi_JWT_CQRS.Api.Core.Application.Features.CQRS.Commands;
using WebApi_JWT_CQRS.Api.Core.Application.Interfaces;
using WebApi_JWT_CQRS.Api.Core.Domain;

namespace WebApi_JWT_CQRS.Api.Core.Application.Features.CQRS.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest, Unit>
    {
        private readonly IRepository<Product> repository;
        public UpdateProductCommandHandler(IRepository<Product> repository)
        {
            this.repository = repository;
        }
        public async Task<Unit> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var updateProduct = await repository.GetByIdAsync(request.Id);

            if (updateProduct == null)
            {
                throw new KeyNotFoundException($"Product with Id {request.Id} not found.");
            }

            updateProduct.CategoryId = request.CategoryId;
            updateProduct.Stock = request.Stock;
            updateProduct.Price = request.Price;
            updateProduct.Name = request.Name;

            await repository.UpdateAsync(updateProduct);

            return Unit.Value;
        }
    }
}
