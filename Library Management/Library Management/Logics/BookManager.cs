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
    }
}
