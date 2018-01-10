using FluentValidation;
using HelpDesk.Domain.Core.Entity;
using System;

namespace HelpDesk.Domain.Chamados
{
    public class Usuario : Entity<Usuario>
    {
        #region construtor
        public Usuario(string nome, string email)
        {
            if (nome == null) throw new ArgumentNullException("nome");
            if (email == null) throw new ArgumentNullException("email");

            Nome = nome;
            Email = email;
        }
        #endregion

        #region properties
        public string Nome { get; private set; }
        public string Email { get; private set; }
        #endregion

        #region methods
        public override bool IsValid()
        {
            RuleFor(p => p.Nome).NotEmpty().WithMessage("O nome não pode ser vazio.");
            RuleFor(p => p.Email).NotEmpty().WithMessage("O e-mail não pode ser vazio.");
            ValidationResult = Validate(this);
            return ValidationResult.IsValid;
        }
        #endregion
    }
}