using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriterDemo {
    class Program {
        static void Main(string[] args) {

            using (var sw = new StreamWriter(@"c:\vidobu\days.txt")) {
                var days = Enum.GetNames(typeof(DayOfWeek));

                foreach (var day in days) {
                    sw.WriteLine(day);
                }

                sw.Flush();
                sw.Close();
            }

            Console.WriteLine("Veri yazıldı");
            Console.ReadKey();
        }
    }
}
