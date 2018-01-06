using AutoMapper;
using HelpDesk.Domain.Chamados.Commands;
using HelpDeskDomain.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDeskDomain.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ChamadoViewModel, SalvarChamadoCommand>();
          
        }
    }
}
