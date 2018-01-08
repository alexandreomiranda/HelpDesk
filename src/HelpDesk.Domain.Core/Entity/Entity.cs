using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Domain.Core.Entity
{
    public abstract class Entity<T> : AbstractValidator<T> where T : Entity<T>
    {
        protected Entity()
        {
        }

        public Guid ID { get; protected set; }
        
        public  ValidationResult ValidationResult{ get; protected set; }

        public abstract bool IsValid();
      


    }
}
