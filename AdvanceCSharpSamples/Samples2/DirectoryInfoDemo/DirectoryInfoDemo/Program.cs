using System;
using System.IO;

namespace DirectoryInfoDemo {
    class Program {
        static void Main(string[] args) {
            var di = new DirectoryInfo(@"C:\vidobu\");

            System.Console.WriteLine(di.CreationTime);

            foreach (var dir in di.EnumerateDirectories("*",SearchOption.AllDirectories)) {
                Console.WriteLine(dir.FullName);
            }

            Console.WriteLine(di.LastAccessTime);

            Console.ReadKey();
        }
    }
}
