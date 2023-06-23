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
            tab[i] = random.Next(100);
        }
        for (i = 0; i <= rozmiar - 1; i++)
        {
            Console.WriteLine(tab[i]);
        }
    }
}