using LecturesProjectExample.Example.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LecturesProjectExample.Example.Data.Configurations
{
    public sealed class StudentsConfiguration : IEntityTypeConfiguration<StudentEntity>
    {
        public void Configure(EntityTypeBuilder<StudentEntity> builder)
        {
            builder
                .ToTable("Students");

            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.FirstName)
                .HasMaxLength(128)
                .IsRequired();

            builder
                .Property(p => p.LastName)
                .HasMaxLength(128)
                .IsRequired();

            builder
                .Property(p => p.Gender)
                .HasDefaultValue(Gender.Undefined)
                .IsRequired();

            builder
                .Property(p => p.YearOfStudying)
                .IsRequired();



        }
    }
}
