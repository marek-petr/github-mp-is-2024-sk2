using System;
using System.Diagnostics;
using System.Globalization;

class Program
{

    static void Main()
    {
        // chci aby se program opakoval po stisku klavesi "a"
        string again = "a";
        while (again == "a")
        {
            //Console.Clear();
            Console.WriteLine("#######################");
            Console.WriteLine("#### Obrazec č.4 ####");
            Console.WriteLine("#######################");
            Console.WriteLine("####### Marek Petr ######");
            Console.WriteLine("#######################\n\n");
            Console.WriteLine();

            // Vstup od uzivatele - TO-DO - spravna varianta
            Console.Write("Zadejte sirku obrazce (cele cislo): ");
            int width;
            while (!int.TryParse(Console.ReadLine(), out width))
            {
                Console.Write("Nezadali jste cele cislo. Zadejte znovu sirku obrazce (cele cislo): ");
            }
            // for (int i = 1; i<=10; i++) {
            //    System.Console.WriteLine(i);
            //  }
            for(int i = 1; i <= width; i++){
                Console.Write("* ");
            }
            Console.WriteLine("");
            for(int i = 1; i <= width-2;i++){
                for(int j = 1; j < width-i; j++){
                    Console.Write("  ");
                }
                Console.Write("* ");
                Console.WriteLine("");
            }
            for(int i = 1; i <= width; i++){
                Console.Write("* ");
            }
            System.Console.WriteLine("\n");

            // Opakovani programu
            Console.WriteLine("Pro opakovani programu stisknete klavesu a");
            again = Console.ReadLine();
        }
    }
} 