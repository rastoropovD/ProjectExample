namespace LecturesProjectExample.Example.Data.Entities;

public record StudentEntity
{
    // student properties
    public string Id { get; init; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public int YearOfStudying { get; init; }
    public Gender Gender { get; init; }
    public virtual ICollection<TeacherStudentEntity> Teachers { get; init; }

    //public StudentEntity(string id, string firstName, string lastName, int yearOfStudying, Gender gender, ICollection<TeacherStudentEntity> teachers)
    //{
    //    Id = id;
    //    FirstName = firstName;
    //    LastName = lastName;
    //    YearOfStudying = yearOfStudying;
    //    Gender = gender;
    //    Teachers = teachers;
    //}

}