using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Product : System.Object
    {
         
        public Product()
        {
            ID = Guid.NewGuid();
        }

        public Guid ID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string PicName { get; set; }


        #region OneToMany Relation ---> one product can have one category & one category can belong to many products
        public virtual Category Category { get; set; }
        #endregion

        #region ManyToMany Relation
        public virtual System.Collections.Generic.IList<Order> Orders { get; set; }
        #endregion
    }
}
