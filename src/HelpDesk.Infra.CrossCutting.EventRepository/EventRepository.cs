using HelpDesk.Domain.Core.Events;
using HelpDesk.Domain.Interfaces;
using System;

namespace HelpDesk.Infra.CrossCutting.EventRepository
{
    public class EventRepository : IEventRepository
    {
        public void Insert(Event @event)
        {
            Console.WriteLine(@event.ToString());
        }
    }
}
