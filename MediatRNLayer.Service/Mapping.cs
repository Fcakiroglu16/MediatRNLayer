using AutoMapper;
using MediatRNlayer.Domain.Dtos;
using MediatRNlayer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatRNLayer.Service
{
    internal class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}