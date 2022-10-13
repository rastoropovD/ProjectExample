using System.Reflection;
using LecturesProjectExample.Example.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace LecturesProjectExample.Example.Data.Context
{
    public sealed class JournalContextDb : DbContext
    {
        public DbSet<StudentEntity> Students { get; set; }
        public DbSet<TeacherEntity> Teachers { get; set; }

        public JournalContextDb(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(JournalContextDb))!);
        }
    }
}
