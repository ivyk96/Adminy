using System.Data.Entity;

namespace Adminy
{
    public class DataContext : DbContext
    {
        public DbSet<Data> Data { get; set; }
    }
}