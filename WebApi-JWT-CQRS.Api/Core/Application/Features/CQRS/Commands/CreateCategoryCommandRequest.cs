using MediatR;

namespace WebApi_JWT_CQRS.Api.Core.Application.Features.CQRS.Commands
{
    public class CreateCategoryCommandRequest : IRequest<Unit>
    {
        public string? Definition { get; set; }
    }
}
