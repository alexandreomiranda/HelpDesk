using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDeskDomain.Application.AutoMapper
{
    //TODO:Inicializar...
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(ps =>
            {
                ps.AddProfile(new DomainToViewModelMappingProfile());
                ps.AddProfile(new ViewModelToDomainMappingProfile());
            });
        }
    }
}
