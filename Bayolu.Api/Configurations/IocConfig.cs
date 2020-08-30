using Bayolu.AppService.Infastructure;
using Bayolu.AppService.Service;
using Bayolu.Domain;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Bayolu.Api.Configurations
{
    public static class IocConfig
    {
        public static void ConfigureDependancy(this IServiceCollection service)
        {
            service.AddTransient<IUnitOfWork, UnitOfWork>();
            service.AddTransient<GenaricRepository<User, Guid>, GenaricRepository<User, Guid>>();
            service.AddTransient<IUserAppService, UserAppService>();
            service.AddTransient<BayolyDbContext, BayolyDbContext>();
        }
    }
}
