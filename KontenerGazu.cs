
public class KontenerGazu : Kontener, IPowiadomienieONiebezpieczenstwie
{
    public double Cisnienie { get; private set; }
    public string RodzajGazu { get; private set; }

    public KontenerGazu(double maksLadownosc, double wysokosc, double glebokosc, double wagaWlasna, double cisnienie, string rodzajGazu)
        : base("G", maksLadownosc, wysokosc, glebokosc, wagaWlasna)
    {
        Cisnienie = cisnienie;
        RodzajGazu = rodzajGazu;
    }

    public override void OproznijLadunek()
    {
        MasaLadunku *= 0.05; // Pozostawienie 5%
    }

    public void PowiadomONiebezpieczenstwie(string wiadomosc)
    {
        Console.WriteLine($"ALERT [{NumerSeryjny}]: {wiadomosc}");
    }

    public override string ToString()
    {
        return base.ToString() + $", Gaz: {RodzajGazu}, Ciśnienie: {Cisnienie} atm";
    }
}