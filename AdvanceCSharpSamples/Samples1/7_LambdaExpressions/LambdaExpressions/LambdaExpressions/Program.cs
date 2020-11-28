using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //args => expression
            //number => number*number;

            // ()=> ...//eğer hiç arguman olmayacak ise
            // x => ... //tek argüman alacak ise
            // (x,y,z) => ..... //birden çok argüman alacak ise

            Func<int, int> square = number => number * number; //Square; 
            Console.WriteLine(square(5));

            //Console.WriteLine(Square(5));
            //Console.ReadLine();


            //Lambda içinde aynı scope içinde başka değişkende kullanılabilir (factor) gibi
            const int factor = 5;
            Func<int, int> multipler = n => n * factor;
            var result = multipler(10);

            Console.WriteLine(result);
            //Console.ReadLine();


            var books = new BookRepository().GetBooks();

            //var cheapBooks = books.FindAll(IsCheaperThan10Dollars); //predicate method ile kullanımı
            var cheapBooks = books.FindAll(b => b.Price < 10); //LambdaExpression hali

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
            Console.ReadLine();
        }

        //static int Square(int number)
        //{
        //    return number * number;
        //}


        //predicate method
        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}
