using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management.Models;

namespace Library_Management.Logics
{
    class CustomerManager
    {
        LibraryDbContext db = new LibraryDbContext();

        public CustomerManager()
        {
            LibraryDbContext db = new LibraryDbContext();
        }

        public List<Customer> GetCusList()
        {
            return db.Customers.ToList();
        }
        public void AddCus(Customer c)
        {
            db.Customers.Add(c);
            db.SaveChanges();
        }

    }
}
