using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Category: System.Object
    {
        public Category()
        {
            ID = Guid.NewGuid();
        }

        public Category(string name)
        {
            this.Name = name;
        }
        public Guid ID { get; set; }
        public string Name { get; set; }

        public virtual System.Collections.Generic.IList<Product> Products { get; set; }
    }
}
