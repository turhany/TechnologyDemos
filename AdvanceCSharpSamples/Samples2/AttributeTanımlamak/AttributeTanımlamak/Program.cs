using System;

namespace AttributeTanımlamak {
    class Program {
        static void Main(string[] args) {
            var kullanici = new Kullanici { Adi = "Türhan"};

            if (KullaniciKontrol.Konrol(kullanici)) {
                Console.WriteLine("Kullanıcı doğru oluşturuldu");
            }
            else {
                Console.WriteLine("Kullanıcı yanlış oluşturuldu");
            }
            Console.ReadKey();
        }
    }
}
