using System;
using System.Collections.Generic;

#nullable disable

namespace DBFirst_Layout_Routing.Models
{
    public partial class Order
    {
        public int Oid { get; set; }
        public int Cid { get; set; }
        public int Pid { get; set; }
        public int Qty { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual Customer CidNavigation { get; set; }
        public virtual Product PidNavigation { get; set; }
    }
}
