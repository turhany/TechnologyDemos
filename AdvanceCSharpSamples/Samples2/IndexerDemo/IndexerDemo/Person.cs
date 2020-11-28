namespace IndexerDemo {
    public class Person {
        private string[] arr;

        public Person() {
            arr = new string[10];
        }

        public string this[int indexNo] {
            get {
                return arr[indexNo];
            }
            set {
                arr[indexNo] = value;
            }
        }
    }
}
