using HelpDesk.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Domain.Chamados.Commands
{
    public class ConcluirChamadoCommand : Command
    {

        #region properties

        public Guid IDChamado { private set; get; }
        public Guid IDUsuario { private set; get; }
        #endregion

        #region constructor

        public ConcluirChamadoCommand(Guid idChamado, Guid idUsuario)
        {
            this.IDChamado = idChamado;
            this.IDUsuario = idUsuario;
        }

        #endregion
    }
}
