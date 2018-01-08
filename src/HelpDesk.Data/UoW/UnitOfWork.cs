using HelpDesk.Domain.Core.Commands;
using HelpDesk.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        public CommandResponse Commit()
        {
            throw new NotImplementedException();
        }
    }
}
