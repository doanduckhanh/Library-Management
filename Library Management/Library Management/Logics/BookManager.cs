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
        }
    }
}
