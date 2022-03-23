using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace socialmedia.models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }

        public DbSet<Student> students{get;set;}
    }
}