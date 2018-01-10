using HelpDesk.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Domain.Chamados.Commands
{
    public class SalvarChamadoCommand : Command
    {
        public Guid IdPessoa { get; private set; }
        public string Descricao { get; private set; }
        public Guid IdAssunto { get; private set; }
        public Guid IdUsuarioCriacao { get; private set; }

        public SalvarChamadoCommand(String descricao, Guid idPessoa, Guid idAssunto, Guid idUsuarioCriacao) 
        {
            Descricao = descricao;
            IdPessoa = idPessoa;
            IdAssunto = idAssunto;
            IdUsuarioCriacao = idUsuarioCriacao;
        }
    }
}
