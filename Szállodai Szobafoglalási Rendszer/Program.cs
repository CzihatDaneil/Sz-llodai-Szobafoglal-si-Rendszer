using Szállodai_Szobafoglalási_Rendszer;
List<Szoba>szobak= new List<Szoba>();


if (File.Exists("szobak.txt"))
{
    foreach (string aktsor in File.ReadAllLines("szobk.txt"))
    {
        string[] adatok =aktsor.Split(';');
        int db = adatok.Count();
        if (db != 4) continue;
        if (int.TryParse(adatok[1], out int emelet) && int.TryParse(adatok[2], out int ar)&& int.TryParse(adatok[3], out int ferohely)) 
        {
            if (!string.IsNullOrWhiteSpace(adatok[0]))
            {
                Szoba aktualis = new Szoba(adatok[0], emelet, ar, ferohely);
                szobak.Add(aktualis);
            }
        }
        
    }
}
else { Console.WriteLine("A szobak.txt nem létezik"); }