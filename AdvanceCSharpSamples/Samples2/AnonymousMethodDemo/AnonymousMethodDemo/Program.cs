using System;

namespace AnonymousMethodDemo {

    public delegate int GetMax(int a, int b);

    class Program {
        static void Main(string[] args) {

            //GetMax gm = delegate (int a, int b) {
            //    return a > b ? a : b;
            //};

            GetMax gm = (int a, int b) => a > b ? a : b;

            System.Console.WriteLine(gm(6, 9));

            Console.ReadKey();

        }
    }
}
