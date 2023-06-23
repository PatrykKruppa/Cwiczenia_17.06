using System;

public class MyProgram
{
    private static Random random = new Random();

    public static void Main(string[] args)
    {
        int Rozmiar, i;

        Rozmiar = 10;
        int[] tab = new int[Rozmiar];

        for (i = 0; i <= Rozmiar - 1; i++)
        {
            tab[i] = random.Next(100);
        }
        for (i = 0; i <= Rozmiar - 1; i++)
        {
            Console.WriteLine(tab[i]);
        }
        int indeksNajmniejszegoElementu;

        indeksNajmniejszegoElementu = 0;
        int pozycjaDoZapisu;

        for (pozycjaDoZapisu = 0; pozycjaDoZapisu <= Rozmiar - 1; pozycjaDoZapisu++)
        {
            indeksNajmniejszegoElementu = pozycjaDoZapisu;
            for (i = pozycjaDoZapisu + 1; i <= Rozmiar - 1; i++)
            {
                if (tab[i] < tab[indeksNajmniejszegoElementu])
                {
                    indeksNajmniejszegoElementu = i;
                }
            }
            int najmniejszaWartosc;

            najmniejszaWartosc = tab[indeksNajmniejszegoElementu];
            tab[indeksNajmniejszegoElementu] = tab[pozycjaDoZapisu];
            tab[pozycjaDoZapisu] = najmniejszaWartosc;
        }
        Console.WriteLine("Po sortowaniu: ");
        for (i = 0; i <= Rozmiar - 1; i++)
       
        {
       
            Console.WriteLine(tab[i]);

        }
        
        Console.ReadLine();
    }
}

