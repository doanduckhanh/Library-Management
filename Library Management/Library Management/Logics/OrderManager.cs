using Library_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.Logics
{
    class OrderManager
    {
        LibraryDbContext db = new LibraryDbContext();

        public OrderManager()
        {
            LibraryDbContext db = new LibraryDbContext();
        }

        public List<Order> GetOrderList()
        {
            return db.Orders.ToList();
        }
    }
}
