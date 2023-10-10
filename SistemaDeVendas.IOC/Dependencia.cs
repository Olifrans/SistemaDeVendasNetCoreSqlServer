﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


//using SistemaDeVendas.DAL.DBContext;

using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.DAL.DBContext;

namespace SistemaDeVendas.IOC
{
    public static class Dependencia
    {
        public static void InjecaoDependencia(this IServiceCollection services, IConfiguration configuration)
        {
            //Injection Dependency ConnectionString Sql Server.
            services.AddDbContext<VendasnetcoreContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ConnectionSistemaDeVendas"));
            });




        }

    }
}