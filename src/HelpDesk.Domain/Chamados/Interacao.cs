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
        public Guid IdUsuario { get; private set; }

        #endregion

        #region Constructor
        protected Interacao(DateTime dataHora, String descricao, Guid idUsuario)
        {


            if (idUsuario == null) throw new ArgumentNullException("usuario");
            DataHora = dataHora;
            Descricao = descricao;
            IdUsuario = idUsuario;


        }
        #endregion

        #region Methods
        public override bool IsValid()
        {
            RuleFor(p => p.Descricao).NotEmpty().WithMessage("A descrição deve ser preenchida.");
            ValidationResult = Validate(this);
            return ValidationResult.IsValid;
        }
        #endregion


    }
}