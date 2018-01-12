using AutoMapper;
using HelpDesk.Data.Context;
using HelpDesk.Data.Repository;
using HelpDesk.Data.UoW;
using HelpDesk.Domain.Chamados.Commands;
using HelpDesk.Domain.Chamados.Events;
using HelpDesk.Domain.Chamados.Repository;
using HelpDesk.Domain.Core.Bus;
using HelpDesk.Domain.Core.Events;
using HelpDesk.Domain.Core.Notifications;
using HelpDesk.Domain.Interfaces;
using HelpDesk.Infra.CrossCutting.Bus;
using HelpDesk.Domain.Application.AutoMapper;
using HelpDesk.Domain.Application.Interfaces;
using HelpDesk.Domain.Application.Services;
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

            //DomainNotifications
            services.AddScoped<IDomainNotificationHandler<DomainNotification>, DomainNotificationHandler>();

            //EventHandler...
            services.AddScoped<IHandler<ChamadoSalvoEvent>, ChamadosEventHandler>();
            services.AddScoped<IHandler<AdicionadaInteracaoChamadoEvent>, ChamadosEventHandler>();
            services.AddScoped<IHandler<AlteradoStatusChamadoEvent >, ChamadosEventHandler>();
            services.AddScoped<IHandler<ChamadoConcluidoEvent> , ChamadosEventHandler > ();

            //CommandHandler...
            services.AddScoped<IHandler<AdicionarInteracaoChamadoCommand>, ChamadoCommandHandler>();
            services.AddScoped<IHandler<AlterarStatusChamadoCommand>, ChamadoCommandHandler>();
            services.AddScoped<IHandler<ConcluirChamadoCommand>, ChamadoCommandHandler>();
            services.AddScoped<IHandler<SalvarChamadoCommand>, ChamadoCommandHandler>();
            
            //EventRepository
            services.AddScoped<IEventRepository, EventRepository.EventRepository>();

            //EventosContext
            services.AddScoped<ChamadosContext>();

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
