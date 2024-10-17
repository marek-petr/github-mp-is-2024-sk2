using System;
using System.Diagnostics;
using System.Globalization;

class Program {

    static void Main() {
        // chci aby se program opakoval po stisku klavesi "a"
        string again = "a";
        while (again == "a") {
            //Console.Clear();
            Console.WriteLine("#######################");
            Console.WriteLine("#### Soucet a soucin ####");
            Console.WriteLine("#######################");   
            Console.WriteLine("####### Marek Petr ######");
            Console.WriteLine("#######################\n\n");   
            Console.WriteLine();

        // Vstup od uživatele - TO-DO - spravna varianta
            Console.Write("Zadejte prvni cislo rady(cele cislo): ");
            int first;
            while(!int.TryParse(Console.ReadLine(), out first)) {
                Console.Write("Nezadali jste cele cislo. Zadejte znovu prvni cislo rady (cele cislo)");
            }

        // Opakování programu
        Console.WriteLine("Pro opakovani programu stisknete klavesu a");
        again = Console.ReadLine();
        }
    }
}