using HelpDesk.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Domain.Chamados.Events
{
    public class AlteradoStatusChamadoEvent : Event
    {

        #region properties
        public Guid IdChamado { get; private set; }
        public Guid IdStatus { get; private set; }
        #endregion

        #region constructor
        public AlteradoStatusChamadoEvent(Guid idChamado, Guid idStatus)
        {
            IdChamado = idChamado;
            IdStatus = IdStatus;
        }
        #endregion
    }
}
