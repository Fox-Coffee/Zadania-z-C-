/**
 * Zadanie 1: Kalkulator
 **/

namespace Zadania_z_C_.funkcje
{
    internal class Kalkulator
    {
        public static void Kalkuluj()
        {
            Console.WriteLine("Podaj liczbę a: ");
            string liczbaa = Console.ReadLine();
            if (!float.TryParse(liczbaa, out float liczba1))
            {
                Console.WriteLine("Błędna liczba");
                return;
            }

            Console.WriteLine("Podaj liczbę b: ");
            string liczbab = Console.ReadLine();
            if (!float.TryParse(liczbab, out float liczba2))
            {
                Console.WriteLine("Błędna liczba");
                return;
            }
            Console.WriteLine("Jaką operację chcesz wykonać? \n1. Dodawanie\n2. Odejmowanie\n3. Mnożenie\n4. Dzielenie\n5. Potęgowanie\n6. Modulo");
            string operacja = Console.ReadLine();

            if (string.IsNullOrEmpty(operacja))
            {
                Console.WriteLine("Nie podano operacji");
                return;
            }

            //działania

            //dodawanie
            else if (operacja == "1")
            {
                Console.WriteLine($"Wynik dodawania {liczba1} + {liczba2} = {liczba1 + liczba2}");
            }

            //odejmowanie
            else if (operacja == "2")
            {
                Console.WriteLine($"Wynik odejmowania {liczba1} - {liczba2} = {liczba1 - liczba2}");
            }

            //mnożenie
            else if (operacja == "3")
            {
                Console.WriteLine($"Wynik mnożenia {liczba1} * {liczba2} = {liczba1 * liczba2}");
            }

            //dzielenie
            else if (operacja == "4")
            {
                if (liczba2 == 0)
                {
                    Console.WriteLine("Nie można dzielić przez 0");
                    return;
                }
                Console.WriteLine($"Wynik dzielenia {liczba1} / {liczba2} = {liczba1 / liczba2}");
            }

            //potęgowanie
            else if (operacja == "5")
            {
                Console.WriteLine($"Wynik potęgowania {liczba1} ^ {liczba2} = {Math.Pow(liczba1, liczba2)}");
            }

            //dzielenie modulo
            else if (operacja == "6")
            {
                if (liczba2 == 0)
                {
                    Console.WriteLine("Nie można dzielić przez 0");
                    return;
                }
                Console.WriteLine($"Wynik modulo {liczba1} % {liczba2} = {liczba1 % liczba2}");
            }

            Console.WriteLine("Czy chcesz kontynuować? \n1. Tak\n2. Nie");
            string kontynuacja = Console.ReadLine();
            if (kontynuacja == "1")
            {
                Kalkuluj();
            }
            else if (kontynuacja == "2")
            {
                return;
            }
            else
            {
                Console.WriteLine("Nieprawidłowy wybór");
                return;
            }
            return;
        }
    }
}
