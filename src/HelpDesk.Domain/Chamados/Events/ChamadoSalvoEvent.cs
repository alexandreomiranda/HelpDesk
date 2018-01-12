using HelpDesk.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Domain.Chamados.Events
{
    public class ChamadoSalvoEvent : Event
    {
        #region properties
        public Guid IdPessoa { get; private set; }
        public string Descricao { get; private set; }
        public Guid IdAssunto { get; private set; }
        public Guid IdUsuarioCriacao { get; private set; }
        public DateTime DataAbertura { get; private set; }
        #endregion

        #region constructor
        public ChamadoSalvoEvent(String descricao, Guid idPessoa, Guid idAssunto, Guid idUsuarioCriacao, DateTime dataAbertura)
        {
            Descricao = descricao;
            IdPessoa = idPessoa;
            IdAssunto = idAssunto;
            IdUsuarioCriacao = idUsuarioCriacao;
            DataAbertura = dataAbertura;
        }
        #endregion
    }
}
