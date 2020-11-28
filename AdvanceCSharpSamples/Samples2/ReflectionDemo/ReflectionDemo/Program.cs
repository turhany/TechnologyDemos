using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo {
    class Program {
        static void Main(string[] args) {
            //Instance Oluşturmak
            //var p = Activator.CreateInstance(typeof(Person)) as Person;
            //p.FirstName = "Türhan";
            //p.LastName = "Yıldırım";

            //p.WritePerson()

            var person = new Person();

            var personType = person.GetType();

            personType.GetProperty("FirstName").SetValue(person, "Türhan");
            personType.GetProperty("LastName").SetValue(person, "Yıldırım");

            personType.InvokeMember("WritePerson", System.Reflection.BindingFlags.InvokeMethod, null, person, null);

            Console.WriteLine();

            foreach (var memberInfo in personType.GetMembers()) {
                Console.WriteLine("{0} {1}", memberInfo.MemberType, memberInfo.Name);
            }

            Console.ReadKey();
        }
    }
}
