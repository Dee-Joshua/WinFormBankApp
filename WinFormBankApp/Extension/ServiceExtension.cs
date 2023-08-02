using BankAppCore.ServiceManager.Abstraction;
using BankAppCore.ServiceManager.Implementation;
using BankAppRepository.Repositories.UnitOfWork.Abstractions;
using BankAppRepository.Repositories.UnitOfWork.Implementations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormBankApp.Extension
{
    public static class ServiceExtension
    {
        public static void ConfigureUnitOfWork(this IServiceCollection services) => services.AddScoped<IUnitOfWork, UnitOfWork>();
        public static void ConfigureServiceManager(this IServiceCollection services) => services.AddScoped<IServiceManager, ServiceManager>();
    }
}
