using HelpDesk.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Domain.Chamados.Events
{
    class ChamadosEventHandler : IHandler<ChamadoConcluidoEvent>
    {
        public void Handle(ChamadoConcluidoEvent message)
        {
            Console.WriteLine(message.ToString());
        }
    }
}
