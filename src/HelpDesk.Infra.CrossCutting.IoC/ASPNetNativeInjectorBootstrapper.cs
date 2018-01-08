using AutoMapper;
using HelpDesk.Data.Repository;
using HelpDesk.Data.UoW;
using HelpDesk.Domain.Chamados.Repository;
using HelpDesk.Domain.Core.Bus;
using HelpDesk.Domain.Interfaces;
using HelpDesk.Infra.CrossCutting.Bus;
using HelpDeskDomain.Application.AutoMapper;
using HelpDeskDomain.Application.Interfaces;
using HelpDeskDomain.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace HelpDesk.Infra.CrossCutting.IoC
{
    public class ASPNetNativeInjectorBootstrapper
    {
        public static void Register(IServiceCollection services)
        {
            //Bus
            services.AddScoped<IBus,InMemoryBus>();

            //Repository
            services.AddScoped<IChamadosRepository, ChamadoRepository>();

            //Service
            services.AddScoped<IChamadoService, ChamadoService>();

            //UoW
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //Mapper
            services.AddSingleton(Mapper.Configuration);
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));
            AutoMapperConfiguration.RegisterMappings();


    }

    }
}
