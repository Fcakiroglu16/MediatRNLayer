using MediatR;
using MediatRNlayer.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatRNlayer.Domain.Queries
{
    public class GetProductQuery : QueryBase<List<ProductDto>>
    {
    }
}