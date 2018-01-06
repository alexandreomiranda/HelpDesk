using AutoMapper;
using HelpDesk.Domain.Chamados;
using HelpDeskDomain.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDeskDomain.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Chamado, ChamadoViewModel>();
          
        }
    }
}
