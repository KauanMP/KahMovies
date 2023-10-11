using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Persistence.Configurations
{
    public static class DbConfigurations
    {
        // public static void MysqlConnection(this IServiceCollection services, IConfiguration config)
        // {
        //     var connectionString = config["mysqlconnection:connectionString"];
        //     var serverVersion = ServerVersion.AutoDetect(connectionString);
        //     services.AddDbContext<ApplicationDbContext>(o => o.UseMySql(connectionString, serverVersion));
        // }

        public static void ScopedConfiguration(this IServiceCollection services)
        {

        }
    }
}
