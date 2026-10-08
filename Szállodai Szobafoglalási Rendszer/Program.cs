using Szállodai_Szobafoglalási_Rendszer;


if (File.Exists("szobak.txt"))
{
    foreach (string aktsor in File.ReadAllLines("szobk.txt"))
    {
        aktsor.Split(';');
        
    }
    //List<Szoba> szobak = new List<Szoba>();

    //string[] adat = File.ReadAllLines("szobak.txt");
    //foreach (string sor in adat)
    //{
    //    string[] adatok = sor.Split(';');
    //}
    //Console.WriteLine(szobak);
}
else { Console.WriteLine("A szobak.txt nem létezik"); }