﻿using HelpDesk.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Domain.Chamados.Commands
{
    public class AlterarStatusChamadoCommand : Command
    {

        #region properties
        public Guid IdChamado  { get; private set; }
        public Guid IdStatus { get; private set; }
        #endregion

        #region constructor
        public AlterarStatusChamadoCommand(Guid idChamado, Guid idStatus)
        {
            IdChamado = idChamado;
            IdStatus = IdStatus;
        }
        #endregion
    }
}
