using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        //Our table will then be set according to this field
        public DbSet<Activity> Activities { get; set; }
    }
}