using Library_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.Logics
{
    class CategoryManager
    {
        LibraryDbContext db = new LibraryDbContext();
        public void AddCate(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }
        public Category FindCate(string catename)
        {
            return db.Categories.FirstOrDefault(x => x.CateName.Contains(catename));
        }
    }
}
