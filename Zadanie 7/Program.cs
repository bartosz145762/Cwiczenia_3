using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Zadanie 7";
        
        Console.WriteLine("Algotym do wypisywania wszystkich par liczb naturalnych, których suma jest równa n");
        Console.WriteLine();

        int n;
        do
        {
            Console.WriteLine("Podaj wartość n");
        } while (!int.TryParse(Console.ReadLine(), out n) || n <= 1);
        Console.WriteLine();

        Console.WriteLine($"Wszystkie pary liczb naturalnych, których suma jest równa {n}: ");
        Console.WriteLine();
        ZnajdzPary(n, 1, -1, "");

        if (n % 2 == 0)
        {
            Console.WriteLine($" {n / 2} {n / 2}");
        }

        Console.ReadLine();
    }

    static void ZnajdzPary(int sumaCel, int start, int ostatniaLiczba, string biezacaPara)
    {
        if (sumaCel == 0 && biezacaPara != "")
        {
            string[] liczby = biezacaPara.Trim().Split(' ');
            if (liczby.Length == 2)
            {
                Console.WriteLine(biezacaPara);
            }
        }
        else if (sumaCel < 0 || start > sumaCel)
        {
            return;
        }

        for (int i = start; i <= sumaCel; i++)
        {
            if (i != ostatniaLiczba)
            {
                ZnajdzPary(sumaCel - i, i, i, biezacaPara + " " + i);
            }
        }
    }
}