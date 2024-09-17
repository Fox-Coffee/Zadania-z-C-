/**
 * Zadanie 4: Liczby pierwsze
 **/

namespace Zadania_z_C_.funkcje
{
    internal class LiczbyPierwsze
    {
        // Funkcja sprawdzająca czy liczba jest pierwsza
        public static bool IsPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        // Funkcja zwracająca listę liczb pierwszych
        public static List<int> Pierwsze(int n)
        {
            List<int> list = new List<int>();
            for (int i = n; i > 0; i--)
            {
                if (IsPrime(i))
                {
                    list.Add(i);
                }
            }
            return list;
        }
        // Główny program
        public static void LPierwsze(string[] args)
        {
            Console.WriteLine("Podaj liczbę: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("---");
            List<int> prime = Pierwsze(n);
            foreach (int i in prime)
            {
                Console.WriteLine(i);
            }
        }
    }
}
