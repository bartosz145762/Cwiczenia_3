using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Title = "Zadanie 8";

        Console.WriteLine("Algorytm do zgadywania jaką liczbę z przedziału 1-20 ma na myśli użytkownik");
        Console.WriteLine();

        Console.WriteLine("Pomyśl liczbę z przedziału od 1 do 20.");
        Console.WriteLine("Napisz liczbę ujemną, jeśli propozycja jest za mała.");
        Console.WriteLine("Napisz liczbę dodatnią, jeśli propozycja jest za duża.");
        Console.WriteLine("Napisz zero, jeśli zgadłem szukaną liczbę.");
        Console.WriteLine("");

        ZgadnijLiczbe(1, 20);

        Console.ReadLine();
    }

    public static int ZgadnijLiczbe(int dolnaGranica, int gornaGranica)
    {
        if (dolnaGranica > gornaGranica)
        {
            throw new ArgumentException("Nieprawidłowy zakres");
        }

        if (dolnaGranica == gornaGranica)
        {
            Console.WriteLine();
            Console.WriteLine("Zgadłem! Szukana liczba to: " + dolnaGranica);
            return dolnaGranica;
        }

        int propozycja = (dolnaGranica + gornaGranica) / 2;
        Console.WriteLine("Czy szukana liczba to: " + propozycja + "?");

        int odpowiedz;
        do
        {
        } while (!int.TryParse(Console.ReadLine(), out odpowiedz));
        Console.WriteLine();

        if (odpowiedz < 0)
        {
            return ZgadnijLiczbe(propozycja + 1, gornaGranica);
        }
        else if (odpowiedz > 0)
        {
            return ZgadnijLiczbe(dolnaGranica, propozycja - 1);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Zgadłem! Szukana liczba to: " + propozycja);
            return propozycja;
        }
    }
}