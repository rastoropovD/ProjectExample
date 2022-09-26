using LecturesProjectExample.Example.Context;
using LecturesProjectExample.Example.Core.Query;
using LecturesProjectExample.Example.Dtos;

namespace LecturesProjectExample.Example.Queries.GetStudentById;

public sealed class GetStudentByIdQueryHandler : IQueryHandler<GetStudentByIdQuery, StudentDto>
{
    private readonly JournalContext _context;

    public GetStudentByIdQueryHandler(JournalContext context)
    {
        _context = context;
    }

    public async Task<StudentDto> Handle(GetStudentByIdQuery query)
    {
        // try to find student by id in the _context.Students
        // map entity to the dto model
        // return dto model
        return new StudentDto();
    }
}