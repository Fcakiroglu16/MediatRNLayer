using MediatR;
using MediatRNlayer.Domain.Command;
using MediatRNlayer.Domain.Dtos;
using MediatRNlayer.Domain.Entities;
using MediatRNLayer.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRNLayer.Service.Handlers.ProductHandler
{
    public class SaveProductHandler : IRequestHandler<SaveProductCommand, ProductDto>
    {
        //Generic repository kullanılmadan data kaydetme
        private readonly AppDbContext _appDbContext;

        public SaveProductHandler(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<ProductDto> Handle(SaveProductCommand request, CancellationToken cancellationToken)
        {
            var product = ObjectMapper.Mapper.Map<Product>(request.Product);

            await _appDbContext.Products.AddAsync(product);

            await _appDbContext.SaveChangesAsync();

            return ObjectMapper.Mapper.Map<ProductDto>(product);
        }
    }
}