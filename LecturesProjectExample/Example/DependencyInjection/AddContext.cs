using LecturesProjectExample.Example.Context;

namespace LecturesProjectExample.Example.DependencyInjection;

public static class AddContext
{
    public static IServiceCollection AddJournalContext(this IServiceCollection services)
    {
        services.AddTransient<JournalContext>();

        return services;
    }
}