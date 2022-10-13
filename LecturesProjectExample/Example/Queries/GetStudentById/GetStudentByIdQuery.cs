using LecturesProjectExample.Example.Core.Query;

namespace LecturesProjectExample.Example.Queries.GetStudentById;

public sealed record GetStudentByIdQuery : IQuery
{
    public string Id { get; init; }

    public GetStudentByIdQuery(string id)
    {
        Id = id;
    }
}