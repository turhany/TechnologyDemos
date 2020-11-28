using System;
using System.IO;

namespace StreamReaderDemo {
    class Program {
        static void Main(string[] args) {
            var filePath = @"c:\vidobu\cs_file.txt";
            StreamReader sr = new StreamReader(filePath);

            //Tek karakter okumak için
            //System.Console.WriteLine((char)sr.Read());
            //System.Console.WriteLine((char)sr.Read());
            //System.Console.WriteLine((char)sr.Read());
            //System.Console.WriteLine((char)sr.Read());
            //System.Console.WriteLine((char)sr.Read());

            //Belirli bir bloktaki karakter dizisini okumak için
            //var charArr = new char[1000];
            //sr.Read(charArr, 0, 15);
            //Console.WriteLine(charArr);

            //Tüm dosyayı okumak için
            //Console.WriteLine(sr.ReadToEnd());

            //Satır satır okumak
            //Console.WriteLine(sr.ReadLine());
            //Console.WriteLine(sr.ReadLine());

            //Tüm dosyayı satır satır okumak
            while (!sr.EndOfStream) {
                Console.WriteLine(sr.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
