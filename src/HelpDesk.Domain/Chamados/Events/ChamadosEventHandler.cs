using HelpDesk.Domain.Core.Events;
using HelpDesk.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Domain.Chamados.Events
{
    public class ChamadosEventHandler :
        IHandler<ChamadoConcluidoEvent>, 
        IHandler<AdicionadaInteracaoChamadoEvent>, 
        IHandler<AlteradoStatusChamadoEvent>,
        IHandler<ChamadoSalvoEvent>
    {
        private IEventRepository _eventRepository;
        public ChamadosEventHandler(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public void Handle(ChamadoConcluidoEvent message)
        {
            HandleMessage(message);
        }

        public void Handle(AlteradoStatusChamadoEvent message)
        {
            HandleMessage(message);
        }

        public void Handle(AdicionadaInteracaoChamadoEvent message)
        {
            HandleMessage(message);
        }

        public void Handle(ChamadoSalvoEvent message)
        {
            HandleMessage(message);
        }

        public void HandleMessage(Event message)
        {
            _eventRepository.Insert(message);
        }
    }
}
