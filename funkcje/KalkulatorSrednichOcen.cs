/**
 * Zadanie 5: Kalkulator średnich ocen
 **/

namespace Zadania_z_C_.funkcje
{
    internal class KalkulatorSrednichOcen
    {
        // Funkcja obliczająca średnią ocen
        public static float Srednia(int[] oceny)
        {
            int suma = oceny.Sum();
            return (float)suma / oceny.Length;
        }
        // Główny program
        public static void KalkulatorSredich()
        {
            Console.WriteLine("Podaj oceny: ");
            string ocenyString = Console.ReadLine();
            string[] oceny = ocenyString.Split(' ');
            Console.WriteLine("Srednia ocen: " + Srednia(oceny.Select(int.Parse).ToArray()));
        }
    }
}
