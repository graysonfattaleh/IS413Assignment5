using System;
using System.Linq;

namespace IS413Assignment5Real.Models
{
    public interface IBooksRepository
    {
        IQueryable<Book> Books { get; }
    }
}
