using HelpDesk.Domain.Core.Bus;
using HelpDeskDomain.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDeskDomain.Application.Interfaces
{
    public interface IChamadoService
    {
        void SalvarChamado(ChamadoViewModel chamado);
        IEnumerable<ChamadoViewModel> RetornarPorUsuario(Guid idUsuario);
        IEnumerable<ChamadoViewModel> RetornarPorPessoa(Guid idPessoa);
        void AdicionarInteracaoChamado(Guid idChamado, InteracaoViewModel interacao);

        void ConcluirChamado(Guid idChamado, Guid idUsuario);

    }
}
