using DonutAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace DonutAPI.Data
{
    public class CheckDbContext : DbContext
    {
        public CheckDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Person>Persons { get; set; }
        public DbSet<Country>Countries { get; set; }
    }
}
