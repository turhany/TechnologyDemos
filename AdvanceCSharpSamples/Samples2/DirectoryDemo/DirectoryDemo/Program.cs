
using System;
using System.IO;

namespace DirectoryDemo {
    class Program {
        static void Main(string[] args) {
            Directory.CreateDirectory("C:\\vidobu\\test1");
            System.Console.WriteLine(Directory.GetCreationTime("C:\\vidobu\\test1"));

            Directory.CreateDirectory("C:\\vidobu\\test2");
            System.Console.WriteLine(Directory.GetCreationTime("C:\\vidobu\\test2"));

            Directory.Move("C:\\vidobu\\test1", "C:\\vidobu\\test2\\test15");

            if (Directory.Exists("C:\\vidobu\\test3"))
                Directory.Delete("C:\\vidobu\\test3");
            
            if (Directory.Exists("C:\\vidobu\\test1"))
                Directory.Delete("C:\\vidobu\\test1");

            Console.ReadKey();

        }
    }
}
