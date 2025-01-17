using Microsoft.EntityFrameworkCore;
using SOS.Models;

namespace SOS.Persistance
{
    public class SosDBContext : DbContext
    {
        public DbSet<Language> Languages { get; set; }
        public DbSet<Person> Persons {get; set;}
        public DbSet<Student> Students {get; set;}
        public DbSet<Instructor> Instructors {get; set;}
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<Course> Courses {get; set;}
        public DbSet<Room> Rooms {get; set;}
        public DbSet<Lesson> Lessons {get; set;}
        public DbSet<DailyRoomPlan> DailyRoomPlans {get; set;}
        public DbSet<DailyPlan> DailyPlans {get; set;}
        public DbSet<MonthlyPlan> MonthlyPlans {get; set;}
        public DbSet<YearlyPlan> YearlyPlans {get; set;}
        public DbSet<Schedule> Schedules {get; set;}
        public SosDBContext(DbContextOptions<SosDBContext> options) : base(options)
         {
             
         }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
         {
             modelBuilder.Entity<StudentCourse>().HasKey(studentCourse => 
                 new { studentCourse.StudentId, studentCourse.CourseId });
         }
    }
}