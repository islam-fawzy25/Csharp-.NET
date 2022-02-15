using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore_Migrations.Models
{
    public class Order
    {
        [Key]
        public int OId { get; set; }
        [ForeignKey("Customer")]
        public int CId { get; set; }
        [ForeignKey("Product")]
        public int PId { get; set; }
        public int Qty { get; set; } = 1;
        public DateTime OrderDate { get; set; } = DateTime.Today;
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
