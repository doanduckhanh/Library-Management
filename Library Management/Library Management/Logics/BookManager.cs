using Library_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.Logics
{
    class BookManager
    {
        LibraryDbContext db = new LibraryDbContext();

        public BookManager()
        {
            LibraryDbContext db = new LibraryDbContext();
        }

        public List<Book> GetBookList()
        {
            return db.Books.ToList();
        }
        public List<Book> GetBookListByCate(int id)
        {
            return db.Books.Where(x => x.CategoryId == id).ToList();
        }
        public void AddBook(Book a)
        {
            db.Books.Add(a);
            db.SaveChanges();
        }
        public void UpdateBook(Book a)
        {
            Book book = db.Books.FirstOrDefault(x => x.Id == a.Id);
            book.Id = a.Id;
            book.Name = a.Name;
            book.CategoryId = a.CategoryId;
            book.Author = a.Author;
            book.Number = a.Number;
            book.EntryDate = a.EntryDate;
            book.Price = a.Price;
            db.SaveChanges ();
        }
        public void DeleteBook(Book a)
        {
            db.Books.RemoveRange(a);
            db.SaveChanges() ;
        }
        public List<Book> Search(string key, string search)
        {
            if (key.Equals("Id"))
            {
                return db.Books.Where(x => x.Id == Convert.ToInt32(search)).ToList();
            }
            else if (key.Equals("Name"))
            {
                return db.Books.Where(x => x.Name.Contains(search)).ToList();
            }
            else if (key.Equals("Author"))
            {
                return db.Books.Where(x => x.Author.Contains(search)).ToList();
            }
            else if (key.Equals("EntryDate"))
            {
                return db.Books.Where(((x) => x.EntryDate == Convert.ToDateTime(search))).ToList();
            }
            else return null;
        }
    }
}
