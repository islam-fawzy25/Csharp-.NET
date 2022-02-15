using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore_Migrations.Models
{
    public class Product
    {
        [Key]
        public int PId { get; set; }
        [Required]
        [DisplayName("Product")]
        public string Name { get; set; }
        public double Price { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
