using AutoMapper;
using HelpDesk.Domain.Chamados;
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
            var command = new AdicionarInteracaoChamadoCommand();
            _bus.SendCommand(command);
        }

        public void ConcluirChamado(Guid idChamado, Guid idUsuario)
        {
            var command = new ConcluirChamadoCommand(idChamado, idUsuario);
            _bus.SendCommand(command);
        }

        public ChamadoViewModel RetornarChamado(Guid idChamado)
        {
            return _mapper.Map<ChamadoViewModel>(_repository.GetById(idChamado));
        }

        public IEnumerable<ChamadoViewModel> RetornarPorPessoa(Guid idPessoa)
        {
            return _mapper.Map<IEnumerable<ChamadoViewModel>>( _repository.RetornarPorPessoa(idPessoa));
        }

        public IEnumerable<ChamadoViewModel> RetornarPorUsuario(Guid idUsuario)
        {
            return _mapper.Map<IEnumerable<ChamadoViewModel>>(_repository.RetornarPorUsuario(idUsuario));
        }

        public void AdicionarChamado(ChamadoViewModel chamado)
        {
            var command = new SalvarChamadoCommand();
            _bus.SendCommand(command);

            
        }

        public void AlterarStatusChamado(Guid idChamado, Status status)
        {
            var command = new AlterarStatusChamadoCommand();
            _bus.SendCommand(command);
        }
    }
}
