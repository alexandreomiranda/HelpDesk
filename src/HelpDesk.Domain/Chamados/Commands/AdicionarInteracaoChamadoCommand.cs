﻿using HelpDesk.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Domain.Chamados.Commands
{
    public class AdicionarInteracaoChamadoCommand : Command
    {
        #region properties
        public DateTime DataHora { get; private set; }
        public String Descricao { get; private set; }
        public Guid IdUsuario { get; private set; }
        public Guid IdChamado { get; private set; }
        #endregion

        #region constructor
        public AdicionarInteracaoChamadoCommand(Guid idChamado, Guid idUsuario, String descricao, DateTime dataHora)
        {
            DataHora = dataHora;
            Descricao = descricao;
            IdUsuario = idUsuario;
            IdChamado = idChamado;
            
        }
        #endregion
    }
}
