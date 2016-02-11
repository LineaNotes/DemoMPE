using System.Data.Common;
using System.Data.Entity;

namespace DemoMPE.Models
{
    public class AsfaltnaBazaContext : DbContext
    {
        public AsfaltnaBazaContext()
        {
        }

        public AsfaltnaBazaContext(DbConnection connection) : base(connection, false)
        {

        }
        public DbSet<Gorivo> Goriva { get; set; }
    }
}