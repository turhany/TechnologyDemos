namespace DelegateKavrami {

    delegate void TestDelegate(int a, int b);

    class Program {
        static void Main(string[] args) {

            var a = 5;
            var b = 3;

            TestDelegate td = new TestDelegate(Topla);

            td(a, b);
        }

        static void Topla(int a, int b) {
            System.Console.WriteLine(a + b);
        }
    }
}
