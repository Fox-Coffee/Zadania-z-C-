/**
 * Zadanie 6: Zamiana jednostek
 **/

namespace Zadania_z_C_.funkcje
{
    internal class ZamianaJednostek
    {
        // Konwersja temperatury z Celsjusza na Farenheita
        public static double toCelcius(double temp)
        {
            return (temp - 32) * 5 / 9;
        }
        // Konwersja temperatury z Farenheita na Celsjusza
        public static double toFarenheit(double temp)
        {
            return temp * 9 / 5 + 32;
        }
        // Główny program
        public static void Temperatura()
        {
            Console.WriteLine("Z której jednostki temperatury?");
            Console.WriteLine("1. Celsjusz na Farenheit");
            Console.WriteLine("2. Farenheit na Celsjusz");
            int from = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj temperaturę:");
            double temp = double.Parse(Console.ReadLine());
            switch (from)
            {
                case 1:
                    Console.WriteLine($"Temperatura wynosi {toFarenheit(temp)} stopni Farenheita");
                    break;
                case 2:
                    Console.WriteLine($"Temperatura wynosi {toCelcius(temp)} stopni Celsjusza");
                    break;
                default:
                    Console.WriteLine("Niepoprawny wybór");
                    break;
            }
        }
    }
}
