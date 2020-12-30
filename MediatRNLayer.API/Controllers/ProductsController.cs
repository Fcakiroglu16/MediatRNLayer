using MediatR;
using MediatRNlayer.Domain.Queries;
using MediatRNlayer.Domain.Repositories;
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
        private readonly IOrnekRepository _repository;

        public ProductsController(IMediator mediator, IOrnekRepository ornekRepository) : base(mediator)
        {
            _repository = ornekRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await QueryAsync(new GetProductQuery());

            return Ok(products);
        }

        [HttpPost]
        public IActionResult topla()
        {
            return Ok(_repository.topla(3, 4));
        }
    }
}