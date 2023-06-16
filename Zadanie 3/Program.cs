using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Zadanie 3";

        Console.WriteLine("Algorytm do obliczania wartości m=(n!-k!)k!");
        Console.WriteLine();

        int n;
        do
        {
            Console.WriteLine("Podaj liczbę n (większą lub równą 5)");
        } while (!int.TryParse(Console.ReadLine(), out n) || n < 5);

        int k;
        do
        {
            Console.WriteLine("Podaj liczbę k (większą lub równą 5)");
        } while (!int.TryParse(Console.ReadLine(), out k) || k < 5);

        long wynik = LiczM(n, k);

        Console.WriteLine();
        Console.WriteLine("Wartość m=(n!-k!)/k! wynosi: " + wynik);

        Console.ReadLine();
    }

    static long LiczM(int n, int k)
    {
        long SilniaN = Silnia(n);
        long SilniaK = Silnia(k);

        long m = (SilniaN - SilniaK) / SilniaK;

        return m;
    }

    static long Silnia(int numer)
    {
        if (numer == 0)
            return 1;
        else
            return numer * Silnia(numer - 1);
    }
}