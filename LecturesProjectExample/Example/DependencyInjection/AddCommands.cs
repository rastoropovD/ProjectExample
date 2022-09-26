using LecturesProjectExample.Example.Commands.AddStudent;
using LecturesProjectExample.Example.Core.Command;

namespace LecturesProjectExample.Example.DependencyInjection;

public static class AddCommands
{
    public static IServiceCollection AddStudentCommands(this IServiceCollection services)
    {
        services.AddScoped<ICommandHandler<AddStudentCommand>, AddStudentCommandHandler>();

        return services;
    }
}