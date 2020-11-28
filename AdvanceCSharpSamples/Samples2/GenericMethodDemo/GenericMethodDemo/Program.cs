using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethodDemo {
    class Program {
        static void Main(string[] args) {

            var byteList1 = new List<byte>();
            var byteList2 = new List<byte>();

            var ld = new ListeDegistirici();

            ld.Degistir<byte>(byteList1, byteList2);


            var intList1 = new List<int>();
            var intList2 = new List<int>();
            
            ld.Degistir<int>(intList1, intList2);

        }
    }
}
