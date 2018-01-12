using AutoMapper;
using HelpDesk.Domain.Chamados;
using HelpDesk.Domain.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Domain.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Chamado, ChamadoViewModel>();
            CreateMap<Interacao, InteracaoViewModel>();
            
        }
    }
}
