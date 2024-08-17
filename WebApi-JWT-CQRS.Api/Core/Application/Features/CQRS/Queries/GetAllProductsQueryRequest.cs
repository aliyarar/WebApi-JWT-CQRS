using MediatR;
using WebApi_JWT_CQRS.Api.Core.Application.Dto;

namespace WebApi_JWT_CQRS.Api.Core.Application.Features.CQRS.Queries
{
    public class GetAllProductsQueryRequest :IRequest<List<ProductListDto>>
    {

    }
}
