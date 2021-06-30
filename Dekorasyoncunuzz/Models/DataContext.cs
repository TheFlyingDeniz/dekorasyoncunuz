using Microsoft.EntityFrameworkCore;

namespace Dekorasyoncunuz.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Dekorasyon> Dekorasyonlar { get; set; }
    }
}
