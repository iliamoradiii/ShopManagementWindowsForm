using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User: System.Object
    {

        public User() 
        {
            ID = Guid.NewGuid();
        }

        public User(string name, string lastname, string phone, string username, string password)
        {
            this.Name = name;
            this.LastName = lastname;
            this.Phone = phone;
            this.UserName = username;
            this.Password = password;
        }

        public Guid ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public string Phone { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }

        public virtual System.Collections.Generic.IList<Order> Orders { get; set; }

    }
}
