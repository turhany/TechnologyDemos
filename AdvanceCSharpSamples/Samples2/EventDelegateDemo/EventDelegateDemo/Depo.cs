
namespace EventDelegateDemo {
    public class Depo {
        public delegate void StokDegistiHandler(object sender, StokDegistiEventArgs e);
        public event StokDegistiHandler StokDegisti;

        private int _stokSayisi;

        public Depo(int stokSayisi) {
            _stokSayisi = stokSayisi;
        }

        public void MalGirisi(int stokSayisi) {
            _stokSayisi += stokSayisi;

            if (StokDegisti != null) {
                StokDegisti(this, new StokDegistiEventArgs() {
                    StokSayisi = _stokSayisi,
                    DegisimMiktari = stokSayisi
                });
            }

        }
        public void MalCikisi(int stokSayisi) {
            _stokSayisi -= stokSayisi;

            if (StokDegisti != null) {
                StokDegisti(this, new StokDegistiEventArgs() {
                    StokSayisi = _stokSayisi,
                    DegisimMiktari = stokSayisi
                });
            }
        }


        public int MevcutStokSayisi {
            get { return _stokSayisi; }
        }
    }
}
