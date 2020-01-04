using Microsoft.EntityFrameworkCore;
using SOS.Models;

namespace SOS.Persistance
{
    public class SosDBContext : DbContext
    {
         public SosDBContext(DbContextOptions<SosDBContext> options) : base(options)
         {
             
         }

         public DbSet<DailyPlan> DailyPlans {get; set;}
         public DbSet<Room> Rooms {get; set;}
         public DbSet<Lesson> Lessons {get; set;}
         public DbSet<Course> Courses {get; set;}
         public DbSet<Student> Students {get; set;}
         public DbSet<Instructor> Instructors {get; set;}
         public DbSet<Schedule> Schedules {get; set;}
    }
}