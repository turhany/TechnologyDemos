using System;
using System.IO;

namespace PathDemo {
    class Program {
        static void Main(string[] args) {
            var fileName = @"c:\vidobu\cs_file.txt";

            Console.WriteLine(Path.GetDirectoryName(fileName));
            Console.WriteLine(Path.GetFileNameWithoutExtension(fileName));
            Console.WriteLine(Path.AltDirectorySeparatorChar);
            Console.WriteLine(Path.VolumeSeparatorChar);
            Console.WriteLine(Path.GetTempFileName());
            Console.WriteLine(Path.GetTempPath());

            Console.ReadKey();
        }
    }
}
