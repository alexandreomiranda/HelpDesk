using FluentValidation;
using HelpDesk.Domain.Core.Entity;
using System;

namespace HelpDesk.Domain.Chamados
{
    public class Interacao : Entity<Interacao>
    {

        #region Properties
        public DateTime DataHora { get; private set; }
        public String Descricao { get; private set; }
        public Usuario Usuario { get; private set; }

        #endregion

        #region Constructor
        protected Interacao(DateTime dataHora, String descricao, Usuario usuario)
        {

            if (usuario == null)
                throw new ArgumentNullException("usuario");
            DataHora = dataHora;
            Descricao = descricao;
            Usuario = usuario;


        }
        #endregion

        #region Methods
  public override bool IsValid()
        {
            RuleFor(p => p.Descricao).NotEmpty().WithMessage("A descrição deve ser preenchida.");

            return ValidationResult.IsValid;
        }
        #endregion

      
    }
}