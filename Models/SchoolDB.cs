using Microsoft.EntityFrameworkCore;

namespace WebApplication.Models
{
    public class SchoolDB : DbContext
    {
        public SchoolDB() : base()
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}