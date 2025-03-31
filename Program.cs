
class Program
{
    static void Main()
    {
        try
        {
            var statek1 = new Statek(5000, 10, 30);
            var statek2 = new Statek(7000, 15, 25);

            // Próba utworzenia kontenerów z błędami
            try
            {
                var kontener1 = new KontenerGazu(1000, 250, 200, 300, 10, "Hel");
                Console.WriteLine("Kontener gazu (1) utworzony");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd tworzenia kontenera gazu: {ex.Message}");
            }

            try
            {
                var kontener2 = new KontenerChlodniczy(900, 200, 200, 300, "Banany", 15); // ❌ zbyt wysoka temperatura
                Console.WriteLine("Kontener chłodniczy (2) utworzony");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd tworzenia kontenera chłodniczego: {ex.Message}");
            }

            try
            {
                var kontener3 = new KontenerCieczy(800, 250, 200, 350, true);
                kontener3.ZaladujLadunek(700); // za dużo (limit to 400)
                Console.WriteLine("Kontener cieczy (3) utworzony i załadowany");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd kontenera cieczy: {ex.Message}");
            }

            // UTWORZENIE POPRAWNYCH KONTENERÓW
            KontenerGazu? kontener4 = null;
            KontenerChlodniczy? kontener5 = null;
            KontenerCieczy? kontener6 = null;

            try
            {
                kontener4 = new KontenerGazu(1000, 250, 200, 300, 8, "Hel");
                kontener4.ZaladujLadunek(900);
                statek1.ZaladujKontener(kontener4);
                Console.WriteLine("Kontener gazu (4) poprawnie utworzony i załadowany");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd (kontener4): {ex.Message}");
            }

            try
            {
                kontener5 = new KontenerChlodniczy(1000, 200, 200, 300, "Banany", 10);
                kontener5.ZaladujProdukt("Banany", 800);
                statek1.ZaladujKontener(kontener5);
                Console.WriteLine("Kontener chłodniczy (5) poprawnie utworzony i załadowany");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd (kontener5): {ex.Message}");
            }

            try
            {
                kontener6 = new KontenerCieczy(1000, 250, 200, 300, false);
                kontener6.ZaladujLadunek(800); // do 90% → OK
                statek1.ZaladujKontener(kontener6);
                Console.WriteLine("Kontener cieczy (6) poprawnie utworzony i załadowany");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd (kontener6): {ex.Message}");
            }

            // Przeniesienie kontenera 5 na drugi statek
            try
            {
                if (kontener5 != null)
                    statek1.PrzeniesKontenerNaInnyStatek(statek2, kontener5.NumerSeryjny);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd przenoszenia kontenera: {ex.Message}");
            }

            // Zastąpienie kontenera 4 nowym kontenerem
            try
            {
                var nowy = new KontenerCieczy(700, 200, 200, 250, false);
                nowy.ZaladujLadunek(500);

                if (kontener4 != null)
                    statek1.ZastapKontener(kontener4.NumerSeryjny, nowy);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd zastępowania kontenera: {ex.Message}");
            }

            // Wypisanie informacji
            Console.WriteLine("\nKontenery na statku 1:");
            statek1.WyswietlInformacje();

            Console.WriteLine("\nKontenery na statku 2:");
            statek2.WyswietlInformacje();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Nieoczekiwany błąd główny: {ex.Message}");
        }
    }
}