using System;
using System.Collections.Generic;

#nullable disable

namespace DBFirst_Layout_Routing.Models
{
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        public int Pid { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
