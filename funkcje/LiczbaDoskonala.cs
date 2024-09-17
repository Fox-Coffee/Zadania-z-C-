/**
 * Zadanie 2: Liczba Doskonała
 **/


namespace Zadania_z_C_.funkcje
{
    internal class LiczbaDoskonala
    {
        // Funkcja sprawdzająca czy liczba jest doskonała
        public static bool LDoskonala(int liczba)
            {
                int suma = 0;
                for (int i = 1; i < liczba; i++)
                {
                    if (liczba % i == 0)
                    {
                        suma += i;
                    }
                }

                return suma == liczba;
            }
        // Główny program
        public static void CzyDoskonala()
            {
                Console.WriteLine("Podaj liczbę: ");
                string input = Console.ReadLine();
                int liczba = int.Parse(input);
                if (LDoskonala(liczba))
                {
                    Console.WriteLine("Liczba jest doskonała");
                }
                else
                {
                    Console.WriteLine("Liczba nie jest doskonała");
                }
            }
    }
}
