/**
 * Zadanie 8: Kalkulator równań kwadratowych
 **/

namespace Zadania_z_C_.funkcje
{
    internal class KalkulatorRownanKwadratowych
    {
        // Obliczanie równań kwadratowych
        public static double[] Kwadratowe(int a, int b, int c)
        {
            int delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                return new double[0];
            }
            else if (delta == 0)
            {
                double x = -1 * b / (2 * a);
                return new double[] { x };
            }
            else
            {
                double x1 = ((-1 * b) - Math.Sqrt(delta)) / (2 * a);
                double x2 = ((-1 * b) + Math.Sqrt(delta)) / (2 * a);
                return new double[] { x1, x2 };
            }
        }
        // Główny program
        public static void KalkulujRownaniaKwadratowe()
        {
            Console.WriteLine("Podaj a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c: ");
            int c = int.Parse(Console.ReadLine());
            double[] wynik = Kwadratowe(a, b, c);
            if (wynik.Length == 0)
            {
                Console.WriteLine("Delta ujemna, brak wyniku");
            }
            else if (wynik.Length == 1)
            {
                Console.WriteLine($"X wynosi {wynik[0]}");
            }
            else
            {
                Console.WriteLine($"X1 wynosi {wynik[0]}\nX2 wynosi {wynik[1]}");
            }
        }
    }
}
