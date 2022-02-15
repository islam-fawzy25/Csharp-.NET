namespace DataBaseFirstDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [Key]
        public int oId { get; set; }

        public int? cId { get; set; }

        public int? pId { get; set; }

        public int? Qty { get; set; }

        public bool? isPaid { get; set; }

        public DateTime? OrderDate { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Product Product { get; set; }
    }
}
