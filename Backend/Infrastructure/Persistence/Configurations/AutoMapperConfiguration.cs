using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Manager.Mappings;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Persistence.Configurations
{
    public static class AutoMapperConfiguration
    {
        public static void UseAutoMapperConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(NewMovieMappingProfile));
        }
    }
}