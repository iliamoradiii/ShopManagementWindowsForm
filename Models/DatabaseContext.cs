using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DatabaseContext : DbContext
    {
        static DatabaseContext()
        {
            Database.SetInitializer(new System.Data.Entity.MigrateDatabaseToLatestVersion<DatabaseContext, Models.Migrations.Configuration>());
        }

        public DatabaseContext() : base("Server=PROXY\\LOCALSQLSERVER;Database=ShopProjetcEF;Integrated Security=True;")
        {
        }

        /// <summary>
        /// onModelCreating method for adding Order configuration in 'Order' class
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new Order.Configuration());
        }



        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }


    }

}
