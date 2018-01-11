using HelpDesk.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Domain.Chamados.Events
{
    class ChamadosEventHandler :
        IHandler<ChamadoConcluidoEvent>, 
        IHandler<AdicionadaInteracaoChamadoEvent>, 
        IHandler<AlteradoStatusChamadoEvent>,
        IHandler<ChamadoSalvoEvent>
    {
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

        public void HandleMessage(Message message)
        {
            Console.WriteLine(message.ToString());
        }
    }
}
