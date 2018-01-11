using HelpDesk.Domain.Chamados.Events;
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
        IHandler<ConcluirChamadoCommand>,
        IHandler<AdicionarInteracaoChamadoCommand>,
IHandler<AlterarStatusChamadoCommand>
    {

        private readonly IChamadosRepository _repository;

        protected ChamadoCommandHandler(IUnitOfWork uow, IBus bus, IDomainNotificationHandler<DomainNotification> notifications, IChamadosRepository repository) : base(uow, bus, notifications)
        {
            _repository = repository;
        }

        public void Handle(SalvarChamadoCommand message)
        {
            _repository.Insert(Chamado.Factory.NovoChamado(message.Descricao,message.IdUsuarioCriacao, message.IdAssunto, message.IdPessoa));
        }

        public void Handle(ConcluirChamadoCommand message)
        {

            var status = Status.RetornarStatusConcluido();
            _repository.AtualizarStatusChamadoConcluido(
                message.IDChamado,
                message.IDUsuario,
                status.ID);

            _bus.RaiseEvent(new ChamadoConcluidoEvent(message.IDChamado, message.IDUsuario, status));

        }

        public void Handle(AdicionarInteracaoChamadoCommand message)
        {
            _repository.AdicionarInteracao(message.IdChamado, new Interacao(message.DataHora, message.Descricao,message.IdUsuario,message.IdChamado));
            _bus.RaiseEvent(new AdicionadaInteracaoChamadoEvent(message.IdChamado,message.IdUsuario,message.Descricao,message.DataHora));
        }

        public void Handle(AlterarStatusChamadoCommand message)
        {
                        _repository.AtualizarStatusChamado(message.IdChamado, message.IdStatus);
            _bus.RaiseEvent(new AlteradoStatusChamadoEvent(message.IdChamado, message.IdStatus));
        }
    }
}
