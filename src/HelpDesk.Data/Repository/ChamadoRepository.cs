using HelpDesk.Domain.Chamados;
using HelpDesk.Domain.Chamados.Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace HelpDesk.Data.Repository
{
    public class ChamadoRepository : IChamadosRepository
    {
        public void AdicionarInteracao(Guid idChamado, Interacao interacao)
        {
            throw new NotImplementedException();
        }

        public void AtualizarStatusChamado(Guid idChamado, Guid idStatus)
        {
            throw new NotImplementedException();
        }

        public void AtualizarStatusChamadoConcluido(Guid idChamado, Guid idUsuario, Guid idStatusConcluido)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Chamado> Find(Expression<Func<Chamado, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Chamado> GetAll()
        {
            throw new NotImplementedException();
        }

        public Chamado GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Chamado obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Chamado> RetornarPorPessoa(Guid idPessoa)
        {
            throw new NotImplementedException();
        }

        public ICollection<Chamado> RetornarPorUsuario(Guid idUsuario)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Chamado obj)
        {
            throw new NotImplementedException();
        }
    }
}
