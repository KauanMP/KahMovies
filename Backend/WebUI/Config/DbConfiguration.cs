using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Interfaces;
using Infrastructure.Persistence;
using Infrastructure.Repository;
using Manager.Implementation;
using Manager.Interfaces.IManager;
using Manager.Interfaces.IRepository;
using Manager.Mappings;
using Microsoft.EntityFrameworkCore;

namespace WebUI.Config
{
    public static class DbConfiguration
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(o =>
            {
                o.AddPolicy("CorsPolicy",
                builder => builder
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowAnyOrigin()
                );
            });
        }

        public static void MysqlConnectionContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["mysqlconnection:connectionString"];
            var serverVersion = ServerVersion.AutoDetect(connectionString);
            services.AddDbContext<ApplicationDbContext>(o => o.UseMySql(connectionString, serverVersion, b => b.MigrationsAssembly("WebUI")));
        }

        public static void UseScopedConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IMovieManager, MovieManager>();
            services.AddScoped<IAuthorManager, AuthorManager>();
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<IUserRepository, UserRepository>();
        }

        public static void UseAutoMapperConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(NewMovieMappingProfile));
            services.AddAutoMapper(typeof(NewAuthorMappingProfile));
            services.AddAutoMapper(typeof(NewCategoryMappingProfile));
            services.AddAutoMapper(typeof(NewLoginMappingProfile));
        }

    }
}
