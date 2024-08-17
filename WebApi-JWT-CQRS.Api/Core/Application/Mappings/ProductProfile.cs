using AutoMapper;
using WebApi_JWT_CQRS.Api.Core.Application.Dto;
using WebApi_JWT_CQRS.Api.Core.Domain;

namespace WebApi_JWT_CQRS.Api.Core.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            this.CreateMap<Product,ProductListDto>().ReverseMap();
        }
    }
}
