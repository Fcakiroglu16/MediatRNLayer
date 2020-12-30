using MediatR;
using MediatRNlayer.Domain.Queries;
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
    public class ProductsController : ApiBaseController
    {
        public ProductsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await QueryAsync(new GetProductQuery());

            return Ok(products);
        }
    }
}