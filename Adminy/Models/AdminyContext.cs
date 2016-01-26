using System.Data.Entity;

namespace Adminy
{
    public class AdminyContext : DbContext
    {
        public DbSet<Shift> Shift { get; set; }
    }
}