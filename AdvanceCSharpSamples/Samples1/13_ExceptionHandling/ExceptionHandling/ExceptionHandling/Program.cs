using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    var calculator = new Calculator();
            //    var result = calculator.Divide(5, 0);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("You cannot divide by zero.");
            //}
            //catch (ArithmeticException ex)
            //{

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Sorry, an unexpected error occured.");
            //}
            //finally
            //{
            //    //Dispose için kullan
            //}


            //Bu şekilde dışarıda değişkeni tanımlayıp finally ile yakalamak yerine using kullanabiliriz.
            //StreamReader streamReader = null;
            //try
            //{
            //    streamReader = new StreamReader(@"C:\file.zip");
            //    streamReader.ReadToEnd();
            //    throw new Exception("Oops");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Sorry, an unexpected error occured.");
            //}
            //finally
            //{
            //    if (streamReader != null)
            //        streamReader.Dispose();
            //}

            //using ile kullanımı
            //try
            //{
            //    using (var streamReader = new StreamReader(@"C:\file.zip"))
            //    {
            //        var content = streamReader.ReadToEnd();
            //    }
            //}
            //catch (Exception ex)//Global excepttion handler
            //{
            //    Console.WriteLine("Sorry, an unexpected error occured.");
            //}


            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("mosh");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
