using System;
using System.Collections.Generic;

#nullable disable

namespace Library_Management.Models
{
    public partial class Book
    {
        public Book()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Author { get; set; }
        public int? Number { get; set; }
        public DateTime EntryDate { get; set; }
        public int Price { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
