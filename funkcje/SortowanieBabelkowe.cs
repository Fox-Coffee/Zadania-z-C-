/**
 * Zadanie 3: Sortowanie Bąbelkowe
 **/

namespace Zadania_z_C_.funkcje
{
    internal class SortowanieBabelkowe
    {
        // Funkcja sortująca
        public static void Sortowanie(int[] tab)
            {
                for (int i = 0; i < tab.Length; i++)
                {
                    for (int j = 0; j < tab.Length - 1; j++)
                    {
                        if (tab[j] > tab[j + 1])
                        {
                            int temp = tab[j];
                            tab[j] = tab[j + 1];
                            tab[j + 1] = temp;
                        }
                    }
                }
            }
        // Główny program
        public static void Sortuj()
            {
                Console.WriteLine("Podaj liczby do posortowania:");
                string input = Console.ReadLine();
                string[] numbers = input.Split(' ');
                int[] tab = new int[numbers.Length];
                for (int i = 0; i < numbers.Length; i++)
                {
                    tab[i] = int.Parse(numbers[i]);
                }
                Sortowanie(tab);
                foreach (var i in tab)
                {
                    System.Console.Write(i + " ");
                }
            }
    }
}
