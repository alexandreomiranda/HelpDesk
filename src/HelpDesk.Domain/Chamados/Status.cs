using FluentValidation;
using HelpDesk.Domain.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Domain.Chamados
{
    public class Status : Entity<Status>
    {

        private static Status _statusConcluido;

        #region construtor
        static Status()
        {
            _statusConcluido = Factory.Create(Guid.Parse("00000000-0000-0000-0000-000000000000"), "Concluído", true);
        }
        
        public Status(Guid id, String nome, bool indicaConcluido)
        {
            ID = id;
            this.Nome = nome;
            this.IndicaConcluido = indicaConcluido;
                     
        }
        #endregion

        #region properties
        public String Nome { private set; get; }
        public bool IndicaConcluido { private set; get; }
        #endregion

        #region methods


        public static Status RetornarStatusConcluido()
        {
            return _statusConcluido;
        }
        public override bool IsValid()
        {
            RuleFor(p => p.Nome)
           .NotEmpty()
           .WithMessage("O nome não pode ser vazio");

            ValidationResult = Validate(this);
            return ValidationResult.IsValid;
        }

        #endregion

        #region factory
        private class Factory
        {
            public static Status Create(Guid id, String nome, bool indicaConcluido)
            {
                return new Status(id, nome,  indicaConcluido);
            }
        }
        #endregion

    }
}
