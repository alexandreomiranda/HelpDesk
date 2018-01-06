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
        protected Chamado(String descricao, Usuario usuario, Assunto assunto, Pessoa pessoa)
        {
            ValidarArgumentos(usuario, assunto, pessoa);
            this.Descricao = descricao;
            this.UsuarioCriacao = usuario;
            this.Assunto = assunto;
            this.Pessoa = pessoa;


        }


        #endregion

        #region Properties

        public DateTime DataAbertura { get; private set; }
        public String Descricao { get; private set; }
        public Usuario UsuarioCriacao { get; private set; }
        public Assunto Assunto { get; private set; }
        public Pessoa Pessoa { get; private set; }

        public Status Status { get; private set; }

        public ICollection<Interacao> Interacoes { get; private set; }

        #endregion

        #region Methods
        private void ValidarArgumentos(Usuario usuario, Assunto assunto, Pessoa pessoa)
        {
            if (usuario == null) throw new ArgumentNullException("descricao");
            if (assunto == null) throw new ArgumentNullException("assunto");
            if (pessoa == null) throw new ArgumentNullException("pessoa");
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
        
        #region Class 
        public class Factory
        {
            public static Chamado NovoChamado(String descricao, Usuario usuario, Assunto assunto, Pessoa pessoa)
            {
                Chamado retorno = new Chamado(descricao, usuario, assunto, pessoa);
                retorno.DataAbertura = DateTime.Now;
                return retorno;
            }
        }
        #endregion

    }
}
