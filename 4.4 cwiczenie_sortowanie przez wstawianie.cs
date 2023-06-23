using System;


public class MyProgram
{

    public static void Main(string[] args)
    {
        int[] tab = new int[] { 10, 2, 4, 5, 6, 7, 2, 1 };

        SortowaniePrzezWstawanie(tab);

        Console.Write("Po sortowaniu przez wstawanie: ");

        for (int i = 0; i < tab.Length; i++)
        {
            Console.Write(" " + tab[i]);
        }
        Console.ReadLine();

    }

    private static void SortowaniePrzezWstawanie(int[] tab)

    {



        int rozmiar = tab.Length;
        int AktualnyElement;

        for (int i = 1; i < rozmiar; i++)

        {
            AktualnyElement = tab[i];
            int j = i - 1;

            while (j >= 0 && tab[j] > AktualnyElement)
            {
                tab[j + 1] = tab[j];
                j = j - 1;
            }

            tab[j + 1] = AktualnyElement;

        }


    }



}