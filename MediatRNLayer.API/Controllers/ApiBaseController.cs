using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRNLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiBaseController : ControllerBase
    {
        protected readonly IMediator _mediator;

        public ApiBaseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected async Task<TResult> QueryAsync<TResult>(IRequest<TResult> query)
        {
            return await _mediator.Send(query);
        }

        protected ActionResult<T> Single<T>(T data)
        {
            if (data == null) return NotFound();
            return Ok(data);
        }

        protected async Task<TResult> CommandAsync<TResult>(IRequest<TResult> command)
        {
            return await _mediator.Send(command);
        }
    }
}