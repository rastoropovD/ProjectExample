using LecturesProjectExample.Example.Core.Query;
using LecturesProjectExample.Example.Dtos;
using LecturesProjectExample.Example.Queries.GetStudentById;

namespace LecturesProjectExample.Example.DependencyInjection;

public static class AddQueries
{
    public static IServiceCollection AddStudentQueries(this IServiceCollection services)
    {
        services
            .AddScoped<IQueryHandler<GetStudentByIdQuery, StudentDto>, GetStudentByIdQueryHandler>();

        return services;
    }
}