using System;
using System.Linq;

namespace IS413Assignment5Real.Models
{
    public class EFBooksRepository: IBooksRepository
    {
        private BookDBContext _context;

        public EFBooksRepository(BookDBContext context)
        {
            _context = context;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
