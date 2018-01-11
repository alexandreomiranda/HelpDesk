using HelpDesk.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Domain.Chamados.Repository
{
    public interface IChamadosRepository : IRepository<Chamado>
    {
        ICollection<Chamado> RetornarPorPessoa(Guid idPessoa);
        ICollection<Chamado> RetornarPorUsuario(Guid idUsuario);
        void AdicionarInteracao(Guid idChamado, Interacao interacao);
        void AtualizarStatusChamadoConcluido(Guid idChamado, Guid idUsuario, Guid idStatusConcluido);
        void AtualizarStatusChamado(Guid idChamado, Guid idStatus);
    }
}
