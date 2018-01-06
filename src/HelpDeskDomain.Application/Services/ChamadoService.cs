using AutoMapper;
using HelpDesk.Domain.Chamados.Commands;
using HelpDesk.Domain.Chamados.Repository;
using HelpDesk.Domain.Core.Bus;
using HelpDesk.Domain.Interfaces;
using HelpDeskDomain.Application.Interfaces;
using HelpDeskDomain.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDeskDomain.Application.Services
{
    public class ChamadoService : IChamadoService
    {
        //TODO: Injetar...
        private readonly IBus _bus;
        private readonly IChamadosRepository _repository;
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

         public ChamadoService(IBus bus, IChamadosRepository repository, IUnitOfWork uow, IMapper mapper)
        {
            _bus = bus;
            _repository = repository;
            _uow = uow;
            _mapper = mapper;
        }

        public void AdicionarInteracaoChamado(Guid idChamado, InteracaoViewModel interacao)
        {
            throw new NotImplementedException();
        }

        public void ConcluirChamado(Guid idChamado, Guid idUsuario)
        {
            var command = new ConcluirChamadoCommand(idChamado, idUsuario);
            _bus.SendCommand(command);
        }

        public IEnumerable<ChamadoViewModel> RetornarPorPessoa(Guid idPessoa)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ChamadoViewModel> RetornarPorUsuario(Guid idUsuario)
        {
            throw new NotImplementedException();
        }

        public void SalvarChamado(ChamadoViewModel chamado)
        {
           var command = _mapper.Map<SalvarChamadoCommand>(chamado);
            _bus.SendCommand(command);

            
        }
    }
}
