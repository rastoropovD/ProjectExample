using LecturesProjectExample.Example.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace LecturesProjectExample.Example.DependencyInjection;

public static class AddContext
{
    public static IServiceCollection AddJournalContext(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<JournalContextDb>(options =>
        {
            options.UseSqlServer(connectionString);
        });

        return services;
    }
}