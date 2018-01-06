using HelpDesk.Domain.Chamados.Repository;
using HelpDesk.Domain.CommandHandlers;
using HelpDesk.Domain.Core.Bus;
using HelpDesk.Domain.Core.Events;
using HelpDesk.Domain.Core.Notifications;
using HelpDesk.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Domain.Chamados.Commands
{
    class ChamadoCommandHandler : CommandHandler, 
        IHandler<SalvarChamadoCommand>,
        IHandler<ConcluirChamadoCommand>
    {

        private readonly IChamadosRepository _repository;

        protected ChamadoCommandHandler(IUnitOfWork uow, IBus bus, IDomainNotificationHandler<DomainNotification> notifications, IChamadosRepository repository) : base(uow, bus, notifications)
        {
            _repository = repository;
        }

        public void Handle(SalvarChamadoCommand message)
        {
            throw new NotImplementedException();
        }

        public void Handle(ConcluirChamadoCommand message)
        {

            
            
        }
    }
}
