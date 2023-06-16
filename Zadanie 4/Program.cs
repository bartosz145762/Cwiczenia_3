using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Zadanie 4";

        Console.WriteLine("Algorytm obliczający zysk z lokaty");
        Console.WriteLine();

        decimal poczatkowa;
        do
        {
            Console.WriteLine("Podaj kwotę początkową");
        } while (!decimal.TryParse(Console.ReadLine(), out poczatkowa) || poczatkowa < 1);

        decimal oprocentowanie;
        do
        {
            Console.WriteLine("Podaj oprocentowanie lokaty w skali roku");
        } while (!decimal.TryParse(Console.ReadLine(), out oprocentowanie) || oprocentowanie < 0);

        int miesiace;
        do
        {
            Console.WriteLine("Podaj długość lokaty w miesiącach");
        } while (!int.TryParse(Console.ReadLine(), out miesiace) || miesiace < 0);

        decimal zysk = Oblicz(poczatkowa, oprocentowanie, miesiace);
        decimal koncowa = poczatkowa + zysk;
        Console.WriteLine();
        Console.WriteLine($"Zysk netto po {miesiace} miesiącach: {zysk:C}");
        Console.WriteLine($"Ostateczna kwota po {miesiace} miesiącach: {koncowa:C}");
    
        Console.ReadLine();
    }

    static decimal Oblicz(decimal poczatkowa, decimal oprocentowanie, int miesiace)
    {
        if (miesiace == 0)
        {
            return 0;
        }
        else
        {
            decimal oprocentowanieMsc = oprocentowanie / 12 / 100;
            decimal zyskMsc = poczatkowa * oprocentowanieMsc;
            decimal belka = 0.19m;
            decimal zyskPodatek = zyskMsc * (1 - belka);

            return zyskPodatek + Oblicz(poczatkowa, oprocentowanie, miesiace - 1);
        }
    }
}