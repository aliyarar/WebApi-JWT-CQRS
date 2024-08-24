﻿using MediatR;
using WebApi_JWT_CQRS.Api.Core.Application.Dto;
using WebApi_JWT_CQRS.Api.Core.Application.Interfaces;
using WebApi_JWT_CQRS.Api.Core.Domain;

namespace WebApi_JWT_CQRS.Api.Core.Application.Features.CQRS.Queries
{
    public class GetCategoriesQueryRequest : IRequest<List<CategoryListDto>>
    {

    }
}
