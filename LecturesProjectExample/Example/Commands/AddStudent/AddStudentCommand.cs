using LecturesProjectExample.Example.Core.Command;
using LecturesProjectExample.Example.Entities;

namespace LecturesProjectExample.Example.Commands.AddStudent;

public sealed class AddStudentCommand : ICommand
{
    // student properties
    public string Id { get; init; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public int YearOfStudying { get; init; }
    public Gender Gender { get; init; }

    public AddStudentCommand(string id, string firstName, string lastName, int yearOfStudying, Gender gender)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        YearOfStudying = yearOfStudying;
        Gender = gender;
    }
}