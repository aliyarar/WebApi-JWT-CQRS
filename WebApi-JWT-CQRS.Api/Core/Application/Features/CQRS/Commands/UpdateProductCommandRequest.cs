using MediatR;

namespace WebApi_JWT_CQRS.Api.Core.Application.Features.CQRS.Commands
{
    public class UpdateProductCommandRequest : IRequest<Unit>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
