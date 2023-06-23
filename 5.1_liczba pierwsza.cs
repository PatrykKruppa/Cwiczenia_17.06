using System;

class Program
{
    static bool LiczbaPierwsza(int liczba)
    {
        if (liczba < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(liczba); i++)
        {
            if (liczba % i == 0)
                return false;
        }

        return true;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Program wypisujący n liczb pierwszych.");
        Console.Write("Podaj wartość n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(n + " liczb pierwszych:");

        int liczenie = 0;
        int AktuaalnaLiczba = 2;

        while (liczenie < n)
        {
            if (LiczbaPierwsza(AktuaalnaLiczba))
            {
                Console.WriteLine(AktuaalnaLiczba);
                liczenie++;
            }

            AktuaalnaLiczba++;
        }
        Console.ReadLine();
    }
}