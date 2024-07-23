using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Order : System.Object
    {


        #region Configuration using FluentApi
        internal class Configuration: System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Order>
        {
            public Configuration()
            {
                HasMany(current => current.Products)
                    .WithMany(Product => Product.Orders)
                    .Map(current =>
                    {
                        current.ToTable("ProductsInOrders");

                        current.MapLeftKey("OrderID");
                        current.MapRightKey("ProductID");
                    });
            }
        }
        #endregion

        public Order()
        {
            OrderID = Guid.NewGuid();
        }
        public Guid OrderID { get; set; } 


        #region OneToMany Relation with User ---> one order just belongs to one user & one user can have many orders
        public virtual User User { get; set; }
        #endregion


        #region ManyToMany Relation With Product
        public virtual System.Collections.Generic.IList<Product> Products { get; set; }
        #endregion
    }
}
