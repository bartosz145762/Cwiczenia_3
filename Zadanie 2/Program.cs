using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Zadanie 2";

        Console.WriteLine("Algorytm do wypisywania wyrazów ciągu Fibbonacciego");
        Console.WriteLine();

        Console.WriteLine("Podaj liczbę wyrazów do wygenerowania");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Pierwsze " + n + " wyrazów ciągu Fibonacciego:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(Fibonacci(i));
        }
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}