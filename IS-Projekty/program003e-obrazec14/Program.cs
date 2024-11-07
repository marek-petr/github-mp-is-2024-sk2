﻿using System;
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
            Console.WriteLine("######################");
            Console.WriteLine("###### Obdelnik ######");
            Console.WriteLine("######################");
            Console.WriteLine("##### Marek Petr #####");
            Console.WriteLine("######################\n\n");
            Console.WriteLine();

            // Vstup od uzivatele - TO-DO - spravna varianta
            Console.Write("Zadejte sirku obrazce (cele cislo): ");
            int width;
            while (!int.TryParse(Console.ReadLine(), out width))
            {
                Console.Write("Nezadali jste cele cislo. Zadejte znovu sirku obrazce (cele cislo): ");
            }
            System.Console.WriteLine("Zadejte vysku obrazce (cele cislo): ");
            int height;
            while (!int.TryParse(Console.ReadLine(), out height))
            {
                Console.Write("Nezadali jste cele cislo. Zadejte znovu vysku obrazce (cele cislo): ");

            }
            // for (int i = 1; i<=10; i++) {
            //    System.Console.WriteLine(i);
            //  }
            for (int i = 0; i <= height/2; i++)
            {
                for (int j = 0; j <= width/2; j++)
                {
                    Console.Write("  ");
                }
                for (int j = width/2+1; j <= width; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
            for (int i = height/2+1; i <= height; i++)
            {
                for (int j = 0; j <= width/2; j++)
                {
                    Console.Write("* ");
                }
                for (int j = width/2+1; j <= width; j++)
                {
                    Console.Write("  ");
                }
                Console.WriteLine("");
            }


            // Opakovani programu
            Console.WriteLine("Pro opakovani programu stisknete klavesu a");
            again = Console.ReadLine();
        }
    }
} 