using Szállodai_Szobafoglalási_Rendszer;

List<Szoba> eszkozok = new List<Szoba>();

string[] adat = File.ReadAllLines("szobak.txt");
foreach (string sor in adat)
{
    string[] adatok = sor.Split(';');
}
Console.WriteLine(eszkozok);
