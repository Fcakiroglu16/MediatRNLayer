using MediatR;
using MediatRNlayer.Domain.Dtos;
using MediatRNlayer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatRNlayer.Domain.Events
{
    public class ProductCreatedEvent : INotification
    {
        public Product Product { get; set; }
    }
}