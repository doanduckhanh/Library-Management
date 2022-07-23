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
        public List<Customer> SearchCustomer(string key, string search)
        {
            if (key.Equals("Id"))
            {
                return db.Customers.Where(x => x.CusId.Contains(search)).ToList();
            }
            else if (key.Equals("Name"))
            {
                return db.Customers.Where(x => x.Name.Contains(search)).ToList();
            }
            else if (key.Equals("Address"))
            {
                return db.Customers.Where(x => x.Address.Contains(search)).ToList();
            }
            else if (key.Equals("State"))
            {
                return db.Customers.Where(x => x.State.Contains(search)).ToList();
            }
            else if (key.Equals("City"))
            {
                return db.Customers.Where(x => x.City.Contains(search)).ToList();
            }
            else if (key.Equals("Dob"))
            {
                return db.Customers.Where(x => x.Birth.ToString().Contains(search)).ToList();
            }
            else if (key.Equals("Phone"))
            {
                return db.Customers.Where(x => x.Phone.Contains(search)).ToList();
            }
            else if (key.Equals("Email"))
            {
                return db.Customers.Where(x => x.Email.Contains(search)).ToList();
            }
            else return null;
        }
    }
}
