using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Title = "Zadanie 6";

        Console.WriteLine("Algorym do sprawdzania czy x jest silnią liczby n");
        Console.WriteLine();

        int x;
        do
        {
            Console.WriteLine("Podaj liczbę x");
        } while (!int.TryParse(Console.ReadLine(), out x));

        int n;
        do
        {
            Console.WriteLine("Podaj liczbę n");
        } while (!int.TryParse(Console.ReadLine(), out n));

        if (sprawdz(x, n))
        {
            Console.WriteLine();
            Console.WriteLine($"Liczba {x} jest silnią liczby {n}, liczba n to {n}");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"Liczba {x} nie jest silnią liczby {n}.");
        }
     
        Console.ReadLine();
    }

    public static bool sprawdz(int x, int n, int silnia = 1)
    {
        if (silnia == x)
        {
            return true;
        }
        else if (silnia > x)
        {
            return false;
        }
        else
        {
            return sprawdz(x, n, silnia * (n + 1));
        }
    }
}