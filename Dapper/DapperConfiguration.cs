using Contracts.IDapperRepository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper
{
    public static class DapperConfiguration
    {

        public static void DapperInstallation(this IServiceCollection services)
        {
            services.AddSingleton<DapperContext>();

            //services.AddScoped<IDapperRepositoryManager, DapperRepositoryManager>();


        }

    }
}
