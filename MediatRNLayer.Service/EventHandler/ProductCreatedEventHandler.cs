using MediatR;
using MediatRNlayer.Domain.Events;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRNLayer.Service.EventHandler
{
    public class ProductCreatedEventHandler : INotificationHandler<ProductCreatedEvent>
    {
        private readonly ILogger<ProductCreatedEvent> _logger;

        public ProductCreatedEventHandler(ILogger<ProductCreatedEvent> logger)
        {
            _logger = logger;
        }

        public Task Handle(ProductCreatedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"ProductCreatedEvent: product id:{notification.Product.Id}");

            return Task.CompletedTask;
        }
    }
}