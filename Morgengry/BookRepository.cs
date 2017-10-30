using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class BookRepository
    {
        List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public Book GetBook(string itemId)
        {
            foreach(Book b in books)
            {
                if(b.ItemId == itemId)
                {
                    return b;
                }
            }
            return null;
        }
        public double GetTotalValue()
        {
            double A = 0.0;
            foreach(Book price in books)
            {
                A += price.Price;
            }
            return A;
        }
    }
}
