public class Statek
{
    private List<Kontener> kontenery = new List<Kontener>();
    public double MaksymalnaWaga { get; private set; }
    public int MaksymalnaLiczbaKontenerow { get; private set; }
    public double Predkosc { get; private set; }

    public Statek(double maksWaga, int maksKontenery, double predkosc)
    {
        MaksymalnaWaga = maksWaga;
        MaksymalnaLiczbaKontenerow = maksKontenery;
        Predkosc = predkosc;
    }

    public void ZaladujKontener(Kontener kontener)
    {
        if (kontenery.Count >= MaksymalnaLiczbaKontenerow)
            throw new Exception("Brak miejsca na statku!");
        kontenery.Add(kontener);
    }

    public void ZaladujListeKontenerow(List<Kontener> lista)
    {
        foreach (var k in lista)
        {
            ZaladujKontener(k);
        }
    }

    public void UsunKontener(string numer)
    {
        kontenery.RemoveAll(k => k.NumerSeryjny == numer);
    }

    public void ZastapKontener(string numer, Kontener nowy)
    {
        UsunKontener(numer);
        ZaladujKontener(nowy);
    }

    public void PrzeniesKontenerNaInnyStatek(Statek inny, string numer)
    {
        var kontener = kontenery.Find(k => k.NumerSeryjny == numer);
        if (kontener != null)
        {
            inny.ZaladujKontener(kontener);
            UsunKontener(numer);
        }
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine($"Statek: Maksymalna waga: {MaksymalnaWaga}, Maksymalna liczba kontenerów: {MaksymalnaLiczbaKontenerow}, Prędkość: {Predkosc}");
        foreach (var kontener in kontenery)
        {
            Console.WriteLine(kontener);
        }
    }
}