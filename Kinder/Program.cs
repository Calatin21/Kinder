namespace Kinder {
    internal class Program {
        static void Main(string[] args) {
            //Kind luedden = new() { Name = "Hänschen", Hungrig = true, Magen = new Magen() { MagenInhalt = new List<Nahrung>() } };
            //Enkelkind lüddenEnkel = new() { Name = "Hänschen", Vorname = "Hans jr.", Hungrig = true, Magen = new() };
            //Fuetterer mudda = new() { Name = "Hänschen", Vorname = "Eva" };
            //Nahrung brei = new() { name = "Brei", Brennwert = 1000 };

            //Console.WriteLine($"Ist das Kind hungrig? {luedden.Hungrig}");
            //mudda.Fuettern(brei, luedden);
            //mudda.Fuettern(brei, luedden);
            //mudda.Fuettern(brei, luedden);
            //Console.WriteLine($"Ist das Kind hungrig? {luedden.Hungrig}");
            //luedden.Toben();
            //luedden.Toben();
            //luedden.Toben();
            //luedden.Toben();

            bool running = true;
            Console.Write("Bitte Deinen Namen eingeben: ");
            String name = Console.ReadLine();
            Console.Write("Bitte Deinen Vornamen eingeben: ");
            String vorname = Console.ReadLine();
            Fuetterer du = new() { Name = name, Vorname = vorname };
            Console.Write("Und wie heisst Dein Kind: ");
            name = Console.ReadLine();
            Kind luedden = new() { Name = name, Hungrig = true, Magen = new Magen() { MagenInhalt = new List<Nahrung>() } };
            Console.Write("Welche Nahrung willst Du Deinem Kind zu essen geben: ");
            name = Console.ReadLine();
            Console.Write($"Wieviel Brennwert hat {name}: ");
            int brennwert = Convert.ToInt32(Console.ReadLine());
            Nahrung nahrung = new() { Name = name, Brennwert = brennwert };

            while (running) {
                Console.Clear();
                Console.WriteLine($"Welche Aktion willst Du ausführen?\n1) Kind toben lassn\n2) Kind füttern\n3) Ist das Kind hungrig?\n4) Was ist im Magen von {luedden.Name}\nq) Beenden");
                name = Console.ReadLine();
                switch (name) {
                    case "1":
                    luedden.Toben();
                    Console.ReadLine();
                    break;
                    case "2":
                    du.Fuettern(nahrung, luedden);
                    break;
                    case "3":
                    Console.WriteLine(luedden.Hungrig);
                    Console.ReadLine();
                    break;
                    case "4":
                    foreach (Nahrung item in luedden.Magen.MagenInhalt) {
                        Console.WriteLine(item.Name);
                    }
                    Console.ReadLine();
                    break;
                    case "q":
                    running = false;
                    break;
                    default:
                    Console.WriteLine("Falsche Eingabe");
                    break;
                }
            }
        }
    }
}