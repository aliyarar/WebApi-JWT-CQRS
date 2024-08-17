using AutoMapper;
using MediatR;
using WebApi_JWT_CQRS.Api.Core.Application.Dto;
using WebApi_JWT_CQRS.Api.Core.Application.Features.CQRS.Queries;
using WebApi_JWT_CQRS.Api.Core.Application.Interfaces;
using WebApi_JWT_CQRS.Api.Core.Domain;

namespace WebApi_JWT_CQRS.Api.Core.Application.Features.CQRS.Handlers
{
    public class GetAllProductsQueryHandler  : IRequestHandler<GetAllProductsQueryRequest, List<ProductListDto>>
    {
        private readonly IRepository<Product> repository;
        private readonly IMapper mapper;

        public GetAllProductsQueryHandler(IRepository<Product> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<ProductListDto>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var data =  await this.repository.GetAllAsync();
            return this.mapper.Map<List<ProductListDto>>(data);
        }
    }
}
