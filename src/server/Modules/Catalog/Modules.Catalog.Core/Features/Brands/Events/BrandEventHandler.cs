﻿using MediatR;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace FluentPOS.Modules.Catalog.Core.Features.Brands.Events
{
    public class BrandEventHandler :
         INotificationHandler<BrandRegisteredEvent>,
        INotificationHandler<BrandUpdatedEvent>,
        INotificationHandler<BrandRemovedEvent>
    {
        private readonly ILogger<BrandEventHandler> _logger;
        private readonly IStringLocalizer<BrandEventHandler> _localizer;

        public BrandEventHandler(ILogger<BrandEventHandler> logger, IStringLocalizer<BrandEventHandler> localizer)
        {
            _logger = logger;
            _localizer = localizer;
        }

        public Task Handle(BrandRegisteredEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation(_localizer[$"{nameof(BrandRegisteredEvent)} Raised."]);
            return Task.CompletedTask;
        }

        public Task Handle(BrandUpdatedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation(_localizer[$"{nameof(BrandUpdatedEvent)} Raised."]);
            return Task.CompletedTask;
        }

        public Task Handle(BrandRemovedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation(_localizer[$"{nameof(BrandRemovedEvent)} Raised. {notification.Id} Removed."]);
            return Task.CompletedTask;
        }
    }
}