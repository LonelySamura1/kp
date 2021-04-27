using KP.Classes;
using System.Data.Entity;
using WpfApp1.Classes;

namespace WFAEntity.API
{
    class MyDBContext : DbContext
    {
        public MyDBContext() : base("MyConnectString")
        {

        }
        public DbSet<Boxes> Boxes { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Material> Materials { get; set; }

        public static WFAEntity.API.MyDBContext DBContext = new WFAEntity.API.MyDBContext();
    }
}
