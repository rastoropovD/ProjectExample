using LecturesProjectExample.Example.Core.Command;
using LecturesProjectExample.Example.Data.Context;
using LecturesProjectExample.Example.Data.Entities;

namespace LecturesProjectExample.Example.Commands.AddStudent;

public sealed class AddStudentCommandHandler : ICommandHandler<AddStudentCommand>
{
    private readonly JournalContextDb _context;

    public AddStudentCommandHandler(JournalContextDb context)
    {
        _context = context;
    }

    public async Task Handle(AddStudentCommand command)
    {
        // validate command's properties
        // save new item _context.Students.Add(); 

        _context.Students.Add(new StudentEntity
            {
                Id = command.Id,
                FirstName = command.FirstName,
                LastName = command.LastName,
                YearOfStudying = command.YearOfStudying,
                Gender = command.Gender
            }
        );
        await _context.SaveChangesAsync();
    }
}