using System;

namespace GenericConstraintDemo {
    class Program {
        static void Main(string[] args) {

            //string struct değildir class'tır
            //var g = new GenericClass<int, string>();

            var g = new GenericClass<int, DateTime, string, MyClass, MyClassWithInterface, DrivenClass>();

        }

        public class DrivenClass : NewClass {

        }

        public class NewClass {

        }

        public class MyClassWithInterface : IDisposable {
            public void Dispose() {
                throw new NotImplementedException();
            }
        }

        public class MyClass {

        }
    }
}
