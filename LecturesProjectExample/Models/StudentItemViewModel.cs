using LecturesProjectExample.Example.Entities;

namespace LecturesProjectExample.Models;

public sealed class StudentItemViewModel
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public int YearOfStudying { get; init; }
    public Gender Gender { get; init; }
}