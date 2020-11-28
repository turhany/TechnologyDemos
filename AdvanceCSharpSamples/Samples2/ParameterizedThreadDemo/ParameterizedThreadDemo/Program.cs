using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParameterizedThreadDemo {
    class Program {
        static void Main(string[] args) {

            var arrThread = new Thread[10];

            for (int i = 0; i < arrThread.Length; i++) {
                arrThread[i] = new Thread(new ParameterizedThreadStart(Yaz));
                arrThread[i].Priority = ThreadPriority.Highest;
                arrThread[i].Start(i);
            }
            Console.ReadKey();
        }


        static void Yaz(object val) {
            Console.WriteLine(val);
        }
    }
}
