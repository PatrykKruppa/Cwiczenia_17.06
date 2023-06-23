using System;

public class MyProgram
{

    public static void Main(string[] args)
    {
        int[] tab = new int[] { 5, 2, 3, 4, 9, 1, 2 };

        SortowanieBabelkowe(tab);

        Console.Write("Wynik sortowania bąbelkowego: ");

        for (int i = 0; i < tab.Length; i++)
        {
            Console.Write(" " + tab[i]);
        }
        Console.ReadLine();
    }

    private static void SortowanieBabelkowe(int[] tab)
    {

        int wymiar = tab.Length;
        bool sortowanie = false;
        while(!sortowanie)
        {

            sortowanie = true;
            for (int i = 0; i < wymiar - 1; i++)
            {
                if (tab[i] > tab[i + 1])
                {
                    int k = tab[i];
                    tab[i] = tab[i + 1];
                    tab[i + 1] = k;
                    sortowanie = false;

                }

            }
            wymiar -= 1;
        }

    }











}