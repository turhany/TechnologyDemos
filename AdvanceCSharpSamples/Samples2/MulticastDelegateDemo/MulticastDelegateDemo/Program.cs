using System;

namespace MulticastDelegateDemo {
    class Program {

        public delegate void Temsilcim();

        static void Main(string[] args) {

            Temsilcim t = new Temsilcim(MethodA);
            t += MethodB;
            t += MethodC;
            t += MethodD;

            t();

            Console.WriteLine();

            t -= MethodB;
            t -= MethodC;

            //t();
            t.Invoke();

            Console.ReadKey();
        }


        public static void MethodA() {
            Console.WriteLine("MethodA");
        }
        public static void MethodB() {
            Console.WriteLine("MethodB");
        }
        public static void MethodC() {
            Console.WriteLine("MethodC");
        }
        public static void MethodD() {
            Console.WriteLine("MethodD");
        }
    }
}
