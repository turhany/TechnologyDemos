using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book() {Title  = "Title 1", Price = 5},
                new Book() {Title  = "Title 2", Price = 7},
                new Book() {Title  = "Title 3", Price = 17}
            };
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
    }
}
