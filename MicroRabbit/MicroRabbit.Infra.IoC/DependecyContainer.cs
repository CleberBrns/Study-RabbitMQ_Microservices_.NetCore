﻿using MicroRabbit.Baking.Application.Interfaces;
using MicroRabbit.Baking.Application.Services;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infra.IoC
{
    public class DependecyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            // Application Repository
            services.AddTransient<IAccountRepository, AccountRepository>();

            // Application Services
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<BankingDbContext>();
        }
    }
}
