using HelpDesk.Data.Context;
using HelpDesk.Domain.Core.Commands;
using HelpDesk.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Data.UoW
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ChamadosContext _context;

        public UnitOfWork(ChamadosContext context)
        {
            _context = context;
        }

        public CommandResponse Commit()
        {
            int rowsAffected = _context.SaveChanges();
            return new CommandResponse(rowsAffected > 0);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
