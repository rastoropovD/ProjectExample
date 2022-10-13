namespace LecturesProjectExample.Example.Data.Entities
{
    public record TeacherEntity
    {
        public string Id { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public virtual ICollection<TeacherStudentEntity> Students { get; init; }

        //public TeacherEntity(string id, string firstName, string lastName, ICollection<TeacherStudentEntity> students)
        //{
        //    Id = id;
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Students = students;
        //}
    }
}
