using HelpDesk.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Domain.Interfaces
{
    public interface IEventRepository
    {
        void Insert(Event @event);
    }
}
