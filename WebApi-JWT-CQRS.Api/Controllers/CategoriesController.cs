﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi_JWT_CQRS.Api.Core.Application.Features.CQRS.Commands;
using WebApi_JWT_CQRS.Api.Core.Application.Features.CQRS.Queries;

namespace WebApi_JWT_CQRS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator mediator;

        public CategoriesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var result = await this.mediator.Send(new GetCategoriesQueryRequest());
            return Ok(result);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await this.mediator.Send(new GetCategoryQueryRequest(id));
            return result == null ? NotFound() : Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryCommandRequest request)
        {
            await this.mediator.Send(request);
            return Created("", request);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateCategoryCommandRequest request)
        {
            await this.mediator.Send(request);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await this.mediator.Send(new DeleteCategoryCommandRequest(id));
            return NoContent();
        }
    }
}
