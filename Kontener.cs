
public interface IPowiadomienieONiebezpieczenstwie
{
    void PowiadomONiebezpieczenstwie(string wiadomosc);
}
public abstract class Kontener
{
    private static int licznik = 1;
    public string NumerSeryjny { get; private set; }
    public double MasaLadunku { get; protected set; }
    public double MaksymalnaLadownosc { get; protected set; }
    public double Wysokosc { get; protected set; }
    public double Glebokosc { get; protected set; }
    public double WagaWlasna { get; protected set; }

    public Kontener(string typ, double maksLadownosc, double wysokosc, double glebokosc, double wagaWlasna)
    {
        NumerSeryjny = $"KON-{typ}-{licznik}";
        licznik++;
        MaksymalnaLadownosc = maksLadownosc;
        Wysokosc = wysokosc;
        Glebokosc = glebokosc;
        WagaWlasna = wagaWlasna;
        MasaLadunku = 0;
    }

    public virtual void ZaladujLadunek(double masa)
    {
        if (MasaLadunku + masa > MaksymalnaLadownosc)
        {
            throw new Exception("OverfillException: Przekroczono maksymalną ładowność!");
        }
        MasaLadunku += masa;
    }

    public virtual void OproznijLadunek()
    {
        MasaLadunku = 0;
    }

    public override string ToString()
    {
        return $"Kontener {NumerSeryjny}: Masa ładunku: {MasaLadunku} kg, Maksymalna ładowność: {MaksymalnaLadownosc} kg";
    }
}