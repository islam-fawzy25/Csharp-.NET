using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore_CodeFirst.Models
{
    public class Order
    {
        [Key]
        public int OId { get; set; }
        public string OrderDetails { get; set; }
        [ForeignKey("Customer")]
        public int CId { get; set; }
        public int Quantity { get; set; }
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
