

using System;
using System.IO;

namespace FileDemo {
    class Program {
        static void Main(string[] args) {
            var filePath = @"c:\vidobu\cs_file.txt";

            if (!File.Exists(filePath)) {
                File.Create(filePath).Close();
            }

            var loremText = "lorem ipsum dolar sit amet.";
            File.WriteAllText(filePath, loremText + Environment.NewLine);

            var strArr = new[] { "Ocak", "Şubat", "Mart" };
            //File.WriteAllLines(filePath,strArr);
            File.AppendAllLines(filePath, strArr);

            Console.WriteLine("Dosyaya veri yazıldı.");

            Console.ReadKey();
        }
    }
}
