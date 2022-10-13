using LecturesProjectExample.Example.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LecturesProjectExample.Example.Data.Configurations
{
    public sealed class TeacherStudentsConfiguration : IEntityTypeConfiguration<TeacherStudentEntity>
    {
        public void Configure(EntityTypeBuilder<TeacherStudentEntity> builder)
        {
            builder
                .ToTable("TeacherStudents");

            builder
                .HasKey(p => new { p.StudentId, p.TeacherId });

            builder
                .HasOne(teacherStudent => teacherStudent.Student)
                .WithMany(student => student.Teachers)
                .HasForeignKey(teacherStudent => teacherStudent.StudentId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

            builder
                .HasOne(teacherStudent => teacherStudent.Teacher)
                .WithMany(teacher => teacher.Students)
                .HasForeignKey(teacherStudent => teacherStudent.TeacherId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

        }
    }
}
