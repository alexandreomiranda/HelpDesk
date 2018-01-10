using FluentValidation;
using HelpDesk.Domain.Core.Entity;

namespace HelpDesk.Domain.Chamados
{
    public class Assunto : Entity<Assunto>
    {

        #region constructor
        public Assunto(string descricao)
        {
            Descricao = descricao;
        }
        #endregion
        
        #region Properties
        public string Descricao { get; private set; }

        #endregion

        #region Methods
        

        public override bool IsValid()
        {
            RuleFor(p => p.Descricao)
             .NotEmpty()
             .WithMessage("A descrição não pode ser vazia.");

            ValidationResult = Validate(this);
            return ValidationResult.IsValid;
        }

        #endregion
    }
}