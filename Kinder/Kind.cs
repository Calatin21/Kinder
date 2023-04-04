namespace Kinder {
    internal class Kind {       
        public string Name { get; set; }
        public bool Hungrig { get; set; }
        public Magen Magen { get; set; }
        public void Toben() {
            if (!Hungrig) {
                Magen.MagenInhalt.RemoveAt(0);
                Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAhhhhhhhh!!!111111111");
                if (Magen.MagenInhalt.Count() == 0) {
                    Hungrig = true;
                }
            }
            else {
                Console.WriteLine($"{Name} ist sehr hungrig");
            }
        }
    }
}
