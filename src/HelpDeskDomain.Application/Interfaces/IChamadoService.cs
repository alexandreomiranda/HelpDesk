using HelpDesk.Domain.Chamados;
using HelpDesk.Domain.Core.Bus;
using HelpDeskDomain.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDeskDomain.Application.Interfaces
{
    public interface IChamadoService
    {
        ChamadoViewModel RetornarChamado(Guid idChamado);
        void AdicionarChamado(ChamadoViewModel chamado);
        IEnumerable<ChamadoViewModel> RetornarPorUsuario(Guid idUsuario);
        IEnumerable<ChamadoViewModel> RetornarPorPessoa(Guid idPessoa);
        void AdicionarInteracaoChamado(Guid idChamado, InteracaoViewModel interacao);
        void ConcluirChamado(Guid idChamado, Guid idUsuario);
        void AlterarStatusChamado(Guid idChamado, Status status);

    }
}
