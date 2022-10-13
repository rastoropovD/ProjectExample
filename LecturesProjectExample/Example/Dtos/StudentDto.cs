using LecturesProjectExample.Example.Data.Entities;

namespace LecturesProjectExample.Example.Dtos;

public sealed record StudentDto
{
    // student properties
    public string Id { get; init; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public Gender Gender { get; init; }
}