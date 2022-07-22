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
        public Customer GetCustomer(string id)
        {
            return db.Customers.FirstOrDefault(x => x.CusId.Equals(id));
        }
        public void UpdateCus(Customer c)
        {
            Customer cus = db.Customers.FirstOrDefault(x => x.CusId.Equals(c.CusId));
            cus.Name = c.Name;
            cus.Address = c.Address;
            cus.State = c.State;
            cus.City = c.City;
            cus.Gender = c.Gender;
            cus.Birth = c.Birth;
            cus.Phone = c.Phone;
            cus.Email = c.Email;
            db.SaveChanges();
        }
        public void DeleteCus(Customer c)
        {
            db.Customers.RemoveRange(c);
            db.SaveChanges();
        }
    }
}
