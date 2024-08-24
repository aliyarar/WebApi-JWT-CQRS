using MediatR;

namespace WebApi_JWT_CQRS.Api.Core.Application.Features.CQRS.Commands
{
    public class DeleteCategoryCommandRequest: IRequest<Unit>
    {
        public int Id { get; set; }

        public DeleteCategoryCommandRequest(int id)
        {
            this.Id = id;
        }
    }
}
