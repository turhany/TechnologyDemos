using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //var numbers = new GenericList<int>();
            //numbers.Add(10);

            //var books = new GenericList<Book>();
            //books.Add(new Book() { Isbn = "321321", Title = "Test" });


            ////System.Collections.Generic

            //var dictionary = new GenericDictionary<string, Book>();
            //dictionary.Add("1234", new Book());


            var number = new Nullable<int>(5);
            Console.WriteLine("Has Value ? " + number.HasValue);
            Console.WriteLine("Value : " + number.GetValueOrDefault());


            var number2 = new Nullable<int>();
            Console.WriteLine("Has Value ? " + number2.HasValue);
            Console.WriteLine("Value : " + number2.GetValueOrDefault());

            Console.ReadLine();

            var dc = new DiscountCaculator<Book>();
            dc.CalculateDiscount(new Book());

        }
    }
}
