using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Zadanie 1";

        Console.WriteLine("Kalkulator do potęgowania przy pomocy mnożenia");
        Console.WriteLine();

        Console.WriteLine("Podaj podstawę");
        int podstawa;
        if (!int.TryParse(Console.ReadLine(), out podstawa) || podstawa <= 0)
        {
            Console.WriteLine("Podstawa musi być liczbą naturalną większą od zera");
            return;
        }

        Console.WriteLine("Podaj wykładnik");
        int wykladnik;
        if (!int.TryParse(Console.ReadLine(), out wykladnik) || wykladnik < 0)
        {
            Console.WriteLine("Wykładnik musi być liczbą naturalną (włącznie z zerem)");
            return;
        }

        int wynik = Poteguj(podstawa, wykladnik);

        Console.WriteLine();
        Console.WriteLine("Wynik: " + wynik);

        Console.ReadLine();
    }

    static int Poteguj(int podstawa, int wykladnik)
    {
        if (wykladnik == 0)
        {
            return 1;
        }
        else
        {
            return podstawa * Poteguj(podstawa, wykladnik - 1);
        }
    }
}