using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InitialFormationService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace InitialFormationService.API.Extensions;

public static class DIExtensions
{
    public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"), options => options.MigrationsAssembly("InitialFormationService.API"));
        });

        return services;
    }
}
