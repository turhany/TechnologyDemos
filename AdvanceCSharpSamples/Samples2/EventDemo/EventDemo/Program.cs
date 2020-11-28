using System;

namespace EventDemo {
    class Program {
        static void Main(string[] args) {

            AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;

            Console.ReadKey();

        }

        private static void CurrentDomain_ProcessExit(object sender, EventArgs e) {
            Console.WriteLine("Güle güle....");
            Console.ReadKey();
        }
    }
}
