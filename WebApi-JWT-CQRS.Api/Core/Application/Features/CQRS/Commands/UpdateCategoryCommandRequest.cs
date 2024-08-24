using MediatR;

namespace WebApi_JWT_CQRS.Api.Core.Application.Features.CQRS.Commands
{
    public class UpdateCategoryCommandRequest :  IRequest<Unit>
    {
        public int Id { get; set; }
        public string? Definition { get; set; }

    }
}
