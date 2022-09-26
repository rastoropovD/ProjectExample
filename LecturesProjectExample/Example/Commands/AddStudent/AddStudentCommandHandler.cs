using LecturesProjectExample.Example.Context;
using LecturesProjectExample.Example.Core.Command;

namespace LecturesProjectExample.Example.Commands.AddStudent;

public sealed class AddStudentCommandHandler : ICommandHandler<AddStudentCommand>
{
    private readonly JournalContext _context;

    public AddStudentCommandHandler(JournalContext context)
    {
        _context = context;
    }

    public async Task Handle(AddStudentCommand command)
    {
        // validate command's properties
        // save new item _context.Students.Add(); 
    }
}