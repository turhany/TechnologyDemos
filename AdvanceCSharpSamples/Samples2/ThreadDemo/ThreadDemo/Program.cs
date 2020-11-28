using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo {
    class Program {
        static void Main(string[] args) {
            //Say1();
            //Say2();

            var th1 = new Thread(Say1);
            var th2 = new Thread(Say2);

            th1.Start();
            th2.Start();

            Console.ReadKey();


        }

        static void Say1() {
            for (int i = 1; i < 20; i += 2) {
                Console.SetCursorPosition(35, 5);
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
        }

        static void Say2() {
            for (int i = 0; i < 20; i += 2) {
                Console.SetCursorPosition(35, 10);
                Console.WriteLine(i);
                Thread.Sleep(500);

            }
        }
    }
}
