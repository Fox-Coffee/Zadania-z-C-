/**
 * Zadanie 7: Symulator gry w kości
 **/

namespace Zadania_z_C_.funkcje
{
    internal class SymulatorGryWKosci
    {
        // Funkcja losująca liczbę z zakresu 1-6
        public static int Rzut()
        {
            Random r = new Random();
            int wynik = r.Next(1, 7);
            return wynik;
        }
        // Główny program
        public static void Rzuty()
        {
            int rzut1 = Rzut();
            Console.WriteLine($"Rzut 1: {rzut1}");
            int rzut2 = Rzut();
            Console.WriteLine($"Rzut 2: {rzut2}");

            Console.WriteLine($"Suma oczek wynosi: {rzut1 + rzut2} ");

            Console.WriteLine("Czy chcesz rzucić jeszcze raz? (t/n)");
            string odpowiedz = Console.ReadLine();
            switch (odpowiedz)
            {
                case "t":
                    Rzuty();
                    break;
                default:
                    break;

            }

        }
    }
}
