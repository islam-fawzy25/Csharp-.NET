using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PhotoSharingApplication.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int PhotoID { get; set; }     
        public string UserName { get; set; }
        [Required]
        [StringLength(100)]
        public string Subject { get; set; }
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
        public virtual Photo Photo { get; set; }
    }
}