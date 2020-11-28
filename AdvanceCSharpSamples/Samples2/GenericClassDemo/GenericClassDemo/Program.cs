using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassDemo {
    class Program {
        static void Main(string[] args) {

            List<int> intList1 = new List<int>();
            intList1.Add(5);
            intList1.Add(4);

            List<int> intList2 = new List<int>();
            intList2.Add(5);
            intList2.Add(4);


            var ld = new ListeDegistirici();
            ld.Degistir(intList1, intList2);

            var byteList1 = new List<byte>();
            byteList1.Add(66);
            byteList1.Add(54);

            var byteList2 = new List<byte>();
            byteList1.Add(33);
            byteList1.Add(25);

            ld.Degistir(byteList1, byteList2);

            var ldg = new ListeDegistiriciGeneric<int>();
            ldg.Degistir(intList1, intList2);

            var ldg2 = new ListeDegistiriciGeneric<byte>();
            ldg2.Degistir(byteList1, byteList2);
        }
    }
}
