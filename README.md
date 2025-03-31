# APBD-Z-CW2-s22478 - Kontenery

Projekt  z przedmiotu **APBD**  – APBD-Z-CW2.

Numer indeksu: **s22478**  
Autor: **Hemimaster**

## 📦 Temat: Symulacja obsługi kontenerów i załadunku na statki

Projekt zawiera aplikację w języku **C#**, symulującą zarządzanie kontenerami na statku.

### 🔧 Zawarte klasy:

- `Kontener` – klasa bazowa
- `KontenerGazu` – z obsługą ciśnienia
- `KontenerCieczy` – z obsługą niebezpiecznego ładunku
- `KontenerChlodniczy` – z kontrolą temperatury
- `Statek` – logika ładowania, usuwania i przenoszenia kontenerów

### 🧪 Funkcjonalności:

- Walidacja typu ładunku i temperatury
- Obsługa wyjątków przy przekroczeniach
- Interfejs `IPowiadomienieONiebezpieczenstwie`
- Stworzenie kontenera danego typu
- Załadowanie ładunku do danego kontenera
- Załadowanie kontenera na statek
- Zastąpienie kontenera na statku o danym numerze innym kontenerem
- Możliwość przeniesienie kontenera między dwoma statkami
- Wypisanie informacji o danym kontenerze
- Wypisanie informacji o danym statku i jego ładunku

### 🚀 Uruchamianie:

Projekt można uruchomić w:

- **JetBrains Rider**
- **Visual Studio**
- **.NET CLI**

📁 Struktura katalogów
Kontenery.csproj
├── Program.cs
├── Kontener.cs
├── KontenerGazu.cs
├── KontenerCieczy.cs
├── KontenerChlodniczy.cs
├── Statek.cs