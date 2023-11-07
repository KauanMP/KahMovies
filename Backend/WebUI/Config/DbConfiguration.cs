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
            services.AddScoped<IDirectorRepository, DirectorRepository>();
            services.AddScoped<IGenreRepository, GenreRepository>();
            services.AddScoped<IMovieManager, MovieManager>();
            services.AddScoped<IDirectorManager, DirectorManager>();
            services.AddScoped<IGenreManager, GenreManager>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProducerRepository, ProducersRepository>();
            services.AddScoped<IProducerManager, ProducersManager>();
            services.AddScoped<IScreenwriteRepository, ScreenwriteRepository>();
            services.AddScoped<IScreenwriteManager, ScreenwriteManager>();
        }

        public static void UseAutoMapperConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(NewMovieMappingProfile));
            services.AddAutoMapper(typeof(NewDirectorMappingProfile));
            services.AddAutoMapper(typeof(NewGenreMappingProfile));
            services.AddAutoMapper(typeof(NewLoginMappingProfile));
            services.AddAutoMapper(typeof(NewProducerMappingProfile));
            services.AddAutoMapper(typeof(NewScreenwriteMappingProfile));
        }

    }
}
