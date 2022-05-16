using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OperasWebApp.Models
{
    public class Opera
    {
        [Key]
        public int OperaId { get; set; }
        [Required]
        [StringLength(100)]  // eller [MaxLength(100)]  
        public string Title { get; set; }
        [CheckValidYear]  // 1598

        public int Year { get; set; }
        [Required]
        public string Composer { get; set; }
    }
}