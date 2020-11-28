using System;

namespace EventDelegateDemo {
    public class StokDegistiEventArgs : EventArgs {
        public int StokSayisi { get; set; }
        public int DegisimMiktari { get; set; }
    }
}
