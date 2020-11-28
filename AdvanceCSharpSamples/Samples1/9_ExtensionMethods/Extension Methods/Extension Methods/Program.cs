using System;
using System.Collections.Generic;
using System.Linq;

namespace Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This supposed to be a very long blog post blah blah blah....";
            var shortenedPost = post.Shorten(5);

            IEnumerable<int> numbers = new List<int>() {1,5,2,3,10,2,18};
            var max = numbers.Max();

            Console.WriteLine(max);

            Console.WriteLine("Shorten string: " + shortenedPost);
            Console.ReadLine();
        }
    }
}
