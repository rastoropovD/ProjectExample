using LecturesProjectExample.Example.Entities;

namespace LecturesProjectExample.Example.Context;

// emulate db context
public sealed class JournalContext
{
    private static List<StudentEntity> _students = new List<StudentEntity>();

    public IList<StudentEntity> Students => _students;
}