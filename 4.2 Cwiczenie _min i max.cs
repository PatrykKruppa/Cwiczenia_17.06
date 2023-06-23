using System;

public class MyProgram
{
    private static Random random = new Random();

    public static void Main(string[] args)
    {

        int rozmiar, i;

        rozmiar = 10;
        int[] tab = new int[rozmiar];

        for (i = 0; i <= rozmiar - 1; i++)
        {
            tab[i] = random.Next(1000);
            Console.WriteLine(tab[i]);
        }
        int min, max;

        min = tab[0];
        max = tab[0];


        for (i = 1; i < rozmiar; i++)
        {
            if (tab[i] < min)
            {
                min = tab[i];

            }
            if (tab[i] > max)
            {
                max = tab[i];

            }
        }

        Console.WriteLine("Najmniejszy element to: " + min);
        Console.WriteLine("Najwiekszy element to: " + max);
        Console.ReadLine();
    }
}