using HelpDesk.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Domain.Chamados.Events
{
    public class ChamadoConcluidoEvent : Event
    {
        public Guid IDChamado { get; private set; }
        public Guid IDUsuario { get; private set; }
        public Status Status { get; private set; }


        public ChamadoConcluidoEvent(Guid idChamado, Guid idUsuario, Status status)
        {
            IDChamado = idUsuario;
            IDUsuario = idUsuario;
            Status = status;
        }
    }
}
