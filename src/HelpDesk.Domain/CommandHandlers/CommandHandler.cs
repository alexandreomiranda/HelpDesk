using HelpDesk.Domain.Core.Bus;
using HelpDesk.Domain.Core.Notifications;
using HelpDesk.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Domain.CommandHandlers
{
    class CommandHandler
    {
        protected readonly IUnitOfWork _uow;
        protected readonly IBus _bus;
        protected readonly IDomainNotificationHandler<DomainNotification> _notifications;

        protected CommandHandler(IUnitOfWork uow, IBus bus, IDomainNotificationHandler<DomainNotification> notifications)
        {
            _uow = uow;
            _bus = bus;
            _notifications = notifications;
        }

    }
}
