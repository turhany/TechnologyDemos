using System.Linq;

namespace AttributeTanımlamak {
    public static class KullaniciKontrol {
        public static bool Konrol(Kullanici kullanici) {
            var retVal = true;

            //validasyon

            //kullanıcı sınıfının tipi üzerinde bulunan tüm property'ler

            var props = kullanici.GetType().GetProperties();

            foreach (var propertInfo in props) {
                if (propertInfo.GetCustomAttributes(typeof(BosOlamazAttribute), true).Any()) {
                    //custom attr. uygulamış propperty

                    var val = propertInfo.GetValue(kullanici) as string;

                    if (string.IsNullOrEmpty(val)) {
                        retVal = false;
                    }
                }
            }

            return retVal;
        }
    }
}
