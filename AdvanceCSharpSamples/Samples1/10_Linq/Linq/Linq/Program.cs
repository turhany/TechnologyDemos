using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Language Integrated Query

            var books = new BookRepository().GetBooks();

            //var cheaperBooks = new List<Book>();
            //foreach (var book in books)
            //{
            //    if (book.Price < 10)
            //        cheaperBooks.Add(book);
            //}


            //Linq Query Operators - bu kısım aslında arka planda Linq Extension Methods translate edilir
            var cheaperBooks =
                from b in books
                where b.Price < 10
                orderby b.Title
                select b.Title;//select b;

            //Linq Extension Methods
            var cheapBooks = books
                                    .Where(b => b.Price < 10)
                                    .OrderBy(b => b.Title)
                                    .Select(b => b.Title);

            foreach (var book in cheapBooks)
                Console.WriteLine(book);
            //Console.WriteLine(book.Title + " " + book.Price);

            Console.ReadLine();

            //var bookItem = books.Single(b => b.Title == "ASP.NET MVC++"); //null gelirse exception fırlatır
            //var bookItem = books.SingleOrDefault(b => b.Title == "ASP.NET MVC++");//null gelme ihtimali varsa kullanılır
            //var bookItem = books.First(b => b.Title == "C# Advanced Topics");
            //var bookItem = books.FirstOrDefault(b => b.Title == "C# Advanced Topics");
            var bookItem = books.LastOrDefault(b => b.Title == "C# Advanced Topics");

            Console.WriteLine(bookItem.Title + " " + bookItem.Price);

            Console.ReadLine();

            //Good for paging
            var pagedBooks = books.Skip(2).Take(3);
            foreach (var book in pagedBooks)
            {
                Console.WriteLine(book.Title + " " + book.Price);
            }

            Console.ReadLine();
            
            var count = books.Count();
            Console.WriteLine(count);

            Console.ReadLine();

            var maxPrice = books.Max(b => b.Price);
            Console.WriteLine(maxPrice);

            var minPrice = books.Min(b => b.Price);
            Console.WriteLine(minPrice);

            var totalPrice = books.Sum(b => b.Price);
            Console.WriteLine(totalPrice);

            var averagePrice = books.Average(b => b.Price);
            Console.WriteLine(averagePrice);

            Console.ReadLine();
        }
    }
}
