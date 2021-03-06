﻿using FluentValidation;
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
        public Guid IdChamado { get; private set; }

        #endregion

        #region Constructor
        public Interacao(DateTime dataHora, String descricao, Guid idUsuario, Guid idChamado)
        {


            if (idUsuario == null) throw new ArgumentNullException("usuario");
            DataHora = dataHora;
            Descricao = descricao;
            IdUsuario = idUsuario;
            IdChamado = IdChamado;


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