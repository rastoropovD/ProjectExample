using LecturesProjectExample.Example.Entities;

namespace LecturesProjectExample.Example.Context;

// emulate db context
public sealed class JournalContext
{
    private readonly List<StudentEntity> _students;

    public IEnumerable<StudentEntity> Students => _students;


    public JournalContext()
    {
        _students = new List<StudentEntity>();
    }

    public Task Insert(StudentEntity entity)
    {
        return Task.Run(() => _students.Add(entity));
    }
}