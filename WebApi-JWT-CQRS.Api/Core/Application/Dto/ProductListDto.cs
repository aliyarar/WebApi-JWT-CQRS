using WebApi_JWT_CQRS.Api.Core.Domain;

namespace WebApi_JWT_CQRS.Api.Core.Application.Dto
{
    public class ProductListDto
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
