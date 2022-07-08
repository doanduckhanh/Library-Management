using System;
using System.Collections.Generic;

#nullable disable

namespace Library_Management.Models
{
    public partial class Category
    {
        public Category()
        {
            Books = new HashSet<Book>();
        }

        public int CateId { get; set; }
        public string CateName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
