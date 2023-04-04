namespace Kinder {
    internal class Fuetterer {
        public string Name { get; set; }
        public string Vorname { get; set; }
        public void Fuettern(Nahrung n, Kind k) {
            k.Magen.MagenInhalt.Add(n);
            if (k.Magen.MagenInhalt.Count() > 0) {
                k.Hungrig = false;
            }
        }
    }
}
