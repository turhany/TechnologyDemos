namespace DefaultKeywordDemo {

    class MyClass<T> {
        void GetData(T t) {
            if (t == null) {
                t = default(T);
            }
        }
    }


    class Program {



        static void Main(string[] args) {



        }
    }
}
