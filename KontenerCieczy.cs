
public class KontenerCieczy : Kontener, IPowiadomienieONiebezpieczenstwie
{
    private bool jestNiebezpieczny;

    public KontenerCieczy(double maksLadownosc, double wysokosc, double glebokosc, double wagaWlasna, bool jestNiebezpieczny)
        : base("L", maksLadownosc, wysokosc, glebokosc, wagaWlasna)
    {
        this.jestNiebezpieczny = jestNiebezpieczny;
    }

    public override void ZaladujLadunek(double masa)
    {
        double maksDopuszczalnaLadownosc = jestNiebezpieczny ? MaksymalnaLadownosc * 0.5 : MaksymalnaLadownosc * 0.9;
        if (masa > maksDopuszczalnaLadownosc)
        {
            PowiadomONiebezpieczenstwie("Próba przeładowania kontenera!");
            throw new Exception("OverfillException");
        }
        base.ZaladujLadunek(masa);
    }

    public void PowiadomONiebezpieczenstwie(string wiadomosc)
    {
        Console.WriteLine($"ALERT [{NumerSeryjny}]: {wiadomosc}");
    }
}