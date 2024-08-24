using MediatR;
using WebApi_JWT_CQRS.Api.Core.Application.Dto;

namespace WebApi_JWT_CQRS.Api.Core.Application.Features.CQRS.Queries
{
    public class GetCategoryQueryRequest : IRequest<CategoryListDto?>
    {
        public int Id { get; set; }
        public GetCategoryQueryRequest(int id)
        {
            this.Id = id;
        }
    }
}
