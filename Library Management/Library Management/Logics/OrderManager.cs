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
        public void AddOrder(Order a)
        {
            db.Orders.Add(a);
            db.SaveChanges();
        }
        public void UpdateOrder(Order a)
        {
            Order o = db.Orders.FirstOrDefault(x => x.OrId == a.OrId);
            o.CusId = a.CusId;
            o.BookId = a.BookId;
            o.StartDat = a.StartDat;
            o.EndDate = a.EndDate;
            o.Status = a.Status;
            db.SaveChanges();
        }
        public void DeleteOrder(Order a)
        {
            Order o = db.Orders.FirstOrDefault(x => x.OrId == a.OrId);
            db.Orders.Remove(o);
            db.SaveChanges();
        }
        public List<Order> GetOrderPending()
        {
            return db.Orders.Where(x => x.EndDate < DateTime.Now && x.Status == false).ToList();
        }
    }
}
