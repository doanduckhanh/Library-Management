using System;
using System.Collections.Generic;

#nullable disable

namespace Library_Management.Models
{
    public partial class Order
    {
        public int OrId { get; set; }
        public string CusId { get; set; }
        public int BookId { get; set; }
        public DateTime StartDat { get; set; }
        public DateTime EndDate { get; set; }
        public bool Status { get; set; }

        public virtual Book Book { get; set; }
        public virtual Customer Cus { get; set; }
    }
}
