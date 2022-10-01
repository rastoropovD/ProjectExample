namespace LecturesProjectExample.Example.Entities;

public sealed record StudentEntity
{
    // student properties
    public string Id { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public int YearOfStudying { get; }
    public Gender Gender { get; }

    public StudentEntity(string id, string firstName, string lastName, int yearOfStudying, Gender gender)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        YearOfStudying = yearOfStudying;
        Gender = gender;
    }

}