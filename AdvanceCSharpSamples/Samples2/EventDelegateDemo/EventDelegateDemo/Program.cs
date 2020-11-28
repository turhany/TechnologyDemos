using System;

namespace EventDelegateDemo {
    class Program {
        static void Main(string[] args) {
            var depo = new Depo(150);
            depo.StokDegisti += Depo_StokDegisti;

            depo.MalCikisi(10);
            //Console.WriteLine("Mevcut Stok: " + depo.MevcutStokSayisi);

            depo.MalGirisi(30);
            //Console.WriteLine("Mevcut Stok: " + depo.MevcutStokSayisi);

            Console.ReadKey();
        }

        private static void Depo_StokDegisti(object sender, StokDegistiEventArgs e) {

            Console.WriteLine("Stok değişti. Stok Sayisi : " + e.StokSayisi + " Değigim Miktarı : " + e.DegisimMiktari);

        }
    }
}
