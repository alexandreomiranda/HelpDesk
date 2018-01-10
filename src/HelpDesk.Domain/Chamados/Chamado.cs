using FluentValidation;
using HelpDesk.Domain.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Domain.Chamados
{
    public class Chamado : Entity<Chamado>
    {
        #region constructor
        protected Chamado(String descricao, Guid idUsuarioCriacao, Guid idAssunto, Guid idPessoa)
        {
            ValidarArgumentos(idUsuarioCriacao, idAssunto, idPessoa);
            this.Descricao = descricao;
            this.IdUsuarioCriacao = idUsuarioCriacao;
            this.IdAssunto = idAssunto;
            this.IdPessoa = idPessoa;


        }


        #endregion

        #region Properties

        public DateTime DataAbertura { get; private set; }
        public String Descricao { get; private set; }
        public Guid IdUsuarioCriacao { get; private set; }
        public Guid IdAssunto { get; private set; }
        public Guid IdPessoa { get; private set; }

        public Guid IdStatus { get; private set; }

        public ICollection<Interacao> Interacoes { get; private set; }

         #endregion

        #region Methods
        private void ValidarArgumentos(Guid idUsuarioCriacao, Guid idAssunto, Guid idPessoa)
        {
            if (idUsuarioCriacao == null) throw new ArgumentNullException("usuario");
            if (idAssunto == null) throw new ArgumentNullException("idassunto");
            if (idPessoa == null) throw new ArgumentNullException("idpessoa");
        }

        public override bool IsValid()
        {

            ValidarDescricao();
            ValidationResult = Validate(this);
            return ValidationResult.IsValid;
        }

        private void ValidarDescricao()
        {
            RuleFor(p => p.Descricao)
              .NotEmpty()
              .WithMessage("A descrição não pode ser vazia.");
        }


        #endregion
        
        #region Factory 
        public class Factory
        {
            public static Chamado NovoChamado(String descricao, Guid idUsuarioCriacao, Guid idAssunto, Guid idPessoa)
            {
                Chamado retorno = new Chamado(descricao, idUsuarioCriacao, idAssunto, idPessoa);
                retorno.DataAbertura = DateTime.Now;
                return retorno;
            }
        }
        #endregion

    }
}
