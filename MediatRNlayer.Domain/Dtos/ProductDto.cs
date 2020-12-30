using System;
using System.Collections.Generic;
using System.Text;

namespace MediatRNlayer.Domain.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}