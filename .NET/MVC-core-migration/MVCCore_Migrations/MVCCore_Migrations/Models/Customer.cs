using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore_Migrations.Models
{
    public class Customer
    {
        [Key]
        public int CId { get; set; }
        [Required]
        [DisplayName("Customer")]
        public string Name { get; set; }
        public string City { get; set; }
        public int Phone { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
