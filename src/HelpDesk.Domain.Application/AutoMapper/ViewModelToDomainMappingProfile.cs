using AutoMapper;
using HelpDesk.Domain.Chamados.Commands;
using HelpDesk.Domain.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Domain.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ChamadoViewModel, SalvarChamadoCommand>();
          
        }
    }
}
