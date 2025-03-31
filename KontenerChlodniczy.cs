
public class KontenerChlodniczy : Kontener
{
    public string RodzajProduktu { get; private set; }
    public double Temperatura { get; private set; }

    private static readonly Dictionary<string, double> MaksymalneTemperatury = new Dictionary<string, double>
    {
        { "Banany", 13.3 }, { "Czekolada", 18 }, { "Ryby", 2 },
        { "Mięso", -15 }, { "Lody", -18 }, { "Mrożona pizza", -30 },
        { "Ser", 7.2 }, { "Kiełbasa", 5 }, { "Masło", 20.5 }, { "Jaja", 19 }
    };

    public KontenerChlodniczy(double maksLadownosc, double wysokosc, double glebokosc, double wagaWlasna, string rodzajProduktu, double temperatura)
        : base("C", maksLadownosc, wysokosc, glebokosc, wagaWlasna)
    {
        if (!MaksymalneTemperatury.ContainsKey(rodzajProduktu))
        {
            throw new Exception("Nieznany produkt!");
        }

        if (temperatura > MaksymalneTemperatury[rodzajProduktu])
        {
            throw new Exception($"Zbyt wysoka temperatura! Maksymalna dopuszczalna temperatura dla produktu {rodzajProduktu} to {MaksymalneTemperatury[rodzajProduktu]}°C.");
        }

        RodzajProduktu = rodzajProduktu;
        Temperatura = temperatura;
    }

    public void ZaladujProdukt(string produkt, double masa)
    {
        if (produkt != RodzajProduktu)
        {
            throw new Exception($"Nie można załadować produktu '{produkt}' do kontenera przeznaczonego na '{RodzajProduktu}'!");
        }

        ZaladujLadunek(masa);
    }
}
