using HelpDesk.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        CommandResponse Commit();

    }
}
