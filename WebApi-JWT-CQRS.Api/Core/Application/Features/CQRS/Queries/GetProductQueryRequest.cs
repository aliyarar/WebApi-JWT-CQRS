using MediatR;
using WebApi_JWT_CQRS.Api.Core.Application.Dto;
using WebApi_JWT_CQRS.Api.Core.Domain;

namespace WebApi_JWT_CQRS.Api.Core.Application.Features.CQRS.Queries
{
    public class GetProductQueryRequest :  IRequest<ProductListDto> 
    {
        public int Id { get; set; }

        public GetProductQueryRequest(int id)
        {
           Id = id;
        }
    }
}
