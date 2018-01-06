
using HelpDesk.Domain.Core.Commands;
using HelpDesk.Domain.Core.Events;

namespace HelpDesk.Domain.Core.Bus
{
    public interface IBus
    {
        void SendCommand<T>(T theCommand) where T : Command;
        void RaiseEvent<T>(T theEvent) where T : Event;
    }
}