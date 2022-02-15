using System;
using System.Collections.Generic;

#nullable disable

namespace DBFirst_Layout_Routing.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int Cid { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
