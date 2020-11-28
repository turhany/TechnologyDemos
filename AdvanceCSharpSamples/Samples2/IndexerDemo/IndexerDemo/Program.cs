using System;

namespace IndexerDemo {
    class Program {
        static void Main(string[] args) {
            var str = "turhanyildirim.com";

            Console.WriteLine(str[6]);
            Console.WriteLine(str[7]);
            Console.WriteLine(str[8]);

            var person = new Person();
            person[0] = "turhany";
            person[1] = "bilal";
            person[2] = "mahmut";

            Console.WriteLine(person[0]);

            Console.ReadKey();
        }
    }
}
