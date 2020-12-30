using MediatRNlayer.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatRNlayer.Domain.Command
{
    public class SaveProductCommand : CommandBase<ProductDto>
    {
        public ProductDto Product { get; set; }
    }
}