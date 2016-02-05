using System.Data.Entity;

namespace DemoMPE.Models
{
    public class GasContext : DbContext
    {

        public GasContext() : base("DemoMPE")
        {

        }
        public DbSet<Gas> Gases { get; set; }
        public DbSet<GasPrice> Prices { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}