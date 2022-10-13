using LecturesProjectExample.Example.Core.Query;
using LecturesProjectExample.Example.Data.Context;
using LecturesProjectExample.Example.Data.Entities;
using LecturesProjectExample.Example.Dtos;
using Microsoft.EntityFrameworkCore;

namespace LecturesProjectExample.Example.Queries.GetStudentById;

public sealed class GetStudentByIdQueryHandler : IQueryHandler<GetStudentByIdQuery, StudentDto>
{
    private readonly JournalContextDb _context;

    public GetStudentByIdQueryHandler(JournalContextDb context)
    {
        _context = context;
    }

    public async Task<StudentDto> Handle(GetStudentByIdQuery query)
    {
        StudentEntity? student = await _context.Students.FirstOrDefaultAsync(p => p.Id == query.Id);

        if (student == null)
        {
            return new StudentDto();
        }

        return new StudentDto
        {
            Id = student.Id,
            FirstName = student.FirstName,
            LastName = student.LastName,
            Gender = student.Gender
        };
    }
}