using System;

class Program

{

    static void Main(string[] args)
    {

        //___+_
        //__+_+_
        //_+_+_+_
        //+_+_+_+_


        //Deklaracja zmiennych
        int WysokoscTrojkata, plus, PusteMiejsca, i;


        //wczytanie wysokosci trojkąta czyli ilosci wierszy
        Console.Write("Jest to program, który narysuje trójkąt ze znaków +");
        Console.Write("\nPodaj wysokość trójkąta: ");
        WysokoscTrojkata = int.Parse(Console.ReadLine());

        for (plus = 1; plus <= WysokoscTrojkata; plus++)
        {

            for (PusteMiejsca = 1; PusteMiejsca <= WysokoscTrojkata - plus; PusteMiejsca++)

            {
                Console.Write(" ");

            }

            for (i = 1; i <= plus; i++)

            {

                Console.Write("+ ");

            }
            Console.WriteLine();
         

        }


    }

}