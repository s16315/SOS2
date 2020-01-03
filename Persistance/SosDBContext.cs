using Microsoft.EntityFrameworkCore;
using SOS.Models;

namespace SOS.Persistance
{
    public class SosDBContext : DbContext
    {
         public SosDBContext(DbContextOptions<SosDBContext> options) : base(options)
         {
             
         }

         public DbSet<DailyPlanLesson> DailyPlanLessons {get; set;}
    }
}