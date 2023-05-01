﻿using ETicaretAPI.Application.Abstraction;
using ETicaretAPI.Persistance.Concretes;
using ETicaretAPI.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddSingleton<IProductService,ProductService>();
            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(Configration.ConnectionString)); 
        }
    }
}
