using Librarry.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Librarry.Data.Services
{
    public class BooksService
    {
        private AppDbContext _context;
        public BooksService(AppDbContext context)
        {
            _context = context;
        }

        //public void AddBook(Book book)
        //{
        //    var _book = new Book()
        //    {
        //        Title = book.Title,
        //        Description = book.Description,
        //        IsRead = book.IsRead,
        //        DateRead = book.DateRead,
        //        Rate = book.Rate,
        //        Genre = book.Genre,
        //        Author = book.Author,
        //        ImageURL = book.ImageURL,
        //        DateAdded = book.DateAdded,
        //    };
        //    _context.Books.Add(_book);
        //    _context.SaveChanges();
        //}
    }
}
