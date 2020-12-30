using AutoMapper;
using MediatR;
using MediatRNlayer.Domain.Dtos;
using MediatRNlayer.Domain.Entities;
using MediatRNlayer.Domain.Queries;
using MediatRNlayer.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRNLayer.Service.Handlers
{
    public class GetProductsHandler : IRequestHandler<GetProductQuery, List<ProductDto>>
    {
        private readonly IRepository<Product> _productRepository;

        public GetProductsHandler(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<ProductDto>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetListAsync(x => x.Id != 0);

            return ObjectMapper.Mapper.Map<List<ProductDto>>(products);
        }
    }
}