namespace LecturesProjectExample.Example.Data.Entities
{
    public record TeacherStudentEntity
    {
        public string StudentId { get; init; }
        public string TeacherId { get; init; }

        public virtual StudentEntity Student { get; init; }
        public virtual TeacherEntity Teacher { get; init; }

        //public TeacherStudentEntity(string studentId, string teacherId, StudentEntity student, TeacherEntity teacher)
        //{
        //    StudentId = studentId;
        //    TeacherId = teacherId;
        //    Student = student;
        //    Teacher = teacher;
        //}
    }
}
