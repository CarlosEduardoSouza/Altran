using Altran.Business.Interfaces;
using Altran.Data.Context;
using Altran.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Altran.Api.Configuration
{
    public static class DependencyInjectonConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            return services;
        }
               
    }
}
