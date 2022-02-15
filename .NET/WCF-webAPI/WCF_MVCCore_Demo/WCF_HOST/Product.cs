namespace WCF_HOST
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [Key]
        public int pId { get; set; }

        [Required]
        [StringLength(55)]
        public string pName { get; set; }

        [Column(TypeName = "money")]
        public decimal? pUnitPrice { get; set; }
    }
}
