using Microsoft.EntityFrameworkCore;

namespace ChangTrackingDemo.Model
{
    public class StudentContext : DbContext
    {
        
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }
    
        public DbSet<Student> StudentDemo{get;set;}

    }
}