using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Title = "Zadanie 5";

        Console.WriteLine("Algorytm szacujący wartość funcji e^x, na podstawie n pierwszych wyrazów przy pomocy szeregu Taylora");
        Console.WriteLine();

        double x;
        do
        {
            Console.WriteLine("Podaj wartość x");
        } while (!double.TryParse(Console.ReadLine(), out x));

        int n;
        do
        {
            Console.WriteLine("Podaj liczbę wyrazów (n)");
        } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

        double result = Taylor(x, n);
        Console.WriteLine();
        Console.WriteLine($"Wartośc przybliżona e^{x} wyliczona na podstawie {n} pierwszych wyrazów wynosi: {result}");

        Console.ReadLine();
    }

    public static double Taylor(double x, int n)
    {
        if (n <= 0)
            return 1;

        double wyraz = Potega(x, n) / Silnia(n);

        return wyraz + Taylor(x, n - 1);
    }

    public static double Potega(double x, int wykladnik)
    {
        if (wykladnik == 0)
            return 1;

        return x * Potega(x, wykladnik - 1);
    }

    public static double Silnia(int n)
    {
        if (n == 0)
            return 1;

        return n * Silnia(n - 1);
    }
}