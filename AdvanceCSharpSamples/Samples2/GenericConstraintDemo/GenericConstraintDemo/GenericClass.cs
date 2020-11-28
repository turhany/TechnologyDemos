using System;
using static GenericConstraintDemo.Program;

namespace GenericConstraintDemo {
    class GenericClass<T, K, L, U, D, M>
        where T : struct
        where K : struct
        where L : class
        where U : class, new()
        where D : IDisposable
        where M : NewClass {

        public GenericClass() {
            var u = new U();
        }
    }
}
