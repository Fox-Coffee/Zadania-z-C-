/**
 * Autor: Silent Cat
 **/

using Zadania_z_C_.funkcje;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Wybierz program: \n1. Kalkulator\n2. Liczba doskonała\n3. Sortowanie bąbelkowe\n4. Liczby Pierwsze\n5. Kalkulator średnich ocen\n6. Zamiana jednostek\n7. Symulator gry w kości\n8. Kalkulator równań kwadratowych");
        string program = Console.ReadLine();
        switch (program)
        {
            case "1":
                Kalkulator.Kalkuluj();
                break;
            case "2":
                LiczbaDoskonala.CzyDoskonala();
                break;
            case "3":
                SortowanieBabelkowe.Sortuj();
                break;
            case "4":
                LiczbyPierwsze.LPierwsze(args);
                break;
            case "5":
                KalkulatorSrednichOcen.KalkulatorSredich();
                break;
            case "6":
                ZamianaJednostek.Temperatura();
                break;
            case "7":
                SymulatorGryWKosci.Rzuty();
                break;
            case "8":
                KalkulatorRownanKwadratowych.KalkulujRownaniaKwadratowe();
                break;
            default:
                Console.WriteLine("Nie ma takiego programu");
                break;
        }
    }
}