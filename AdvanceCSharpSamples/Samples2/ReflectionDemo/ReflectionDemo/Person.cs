namespace ReflectionDemo {
    public class Person {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName() {
            return string.Format("{0} {1}", FirstName, LastName);
        }

        public void WritePerson() {
            System.Console.WriteLine("FirstName : {0}", FirstName);
            System.Console.WriteLine("LastName : {0}", LastName);
            System.Console.WriteLine("FullName : {0}", GetFullName());
        }
    }
}
