using JSUSIS.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace JSUSIS.Infrastructure.Persistence.Data
{
    public class JSUSISDbContext : DbContext, IJSUSISDbContext
    {
        public DbSet<Program> Programs { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Professor> Professors { get; set; }

        public JSUSISDbContext(DbContextOptions<JSUSISDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
