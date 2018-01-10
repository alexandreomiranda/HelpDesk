using FluentValidation;
using HelpDesk.Domain.Core.Entity;
using System;

namespace HelpDesk.Domain.Chamados
{
    public class Pessoa : Entity<Pessoa>
    {
        #region construtor
        public Pessoa(string nome, Guid idUsuario)
        {
            if (nome == null) { throw new ArgumentNullException("nome"); }
            if (idUsuario == null) { throw new ArgumentNullException("usuario"); }
            Nome = nome;
            IdUsuario = idUsuario;
                     
        }
        #endregion

        #region properties
        public string Nome { get; private set; }
        
        public Guid IdUsuario { get; private set; }
        #endregion

        #region methods
        public override bool IsValid()
        {
            RuleFor(p => p.Nome).NotEmpty().WithMessage("O nome não pode ser vazio.");
            ValidationResult = Validate(this);
            return ValidationResult.IsValid;
        }
        #endregion
    }
}