using LecturesProjectExample.Example.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LecturesProjectExample.Example.Data.Configurations
{
    public sealed class TeachersConfiguration : IEntityTypeConfiguration<TeacherEntity>
    {
        public void Configure(EntityTypeBuilder<TeacherEntity> builder)
        {
            builder
                .ToTable("Teachers");

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
        }
    }
}
