using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSUSIS.Domain.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string CourseTitle { get; set; }
        public string CourseCode { get; set; }
        public double Units { get; set; }
        public bool HasLaboratory { get; set; }
        public List<ProgramSemester> Semesters { get; set; }
    }

    //Use this to map to ORM
    //public class ApplicationDbContext : DbContext
    //{
    //    public DbSet<Program> Programs { get; set; }
    //    public DbSet<Course> Courses { get; set; }

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Entity<Program>()
    //            .HasMany(p => p.Courses)
    //            .WithMany(c => c.Programs)
    //            .UsingEntity(j => j.ToTable("ProgramCourses")); // Optional: specify join table name
    //    }
    //}
}
