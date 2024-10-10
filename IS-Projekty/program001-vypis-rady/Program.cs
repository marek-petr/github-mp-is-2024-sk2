using System;
using System.Diagnostics;
using System.Globalization;

class Program {

    static void Main() {
        // chci aby se program opakoval po stisku klavesi "a"
        string again = "a";
        while (again == "a") {
            //Console.Clear();
            Console.WriteLine("##################");
            Console.WriteLine("####Výpis řady####");
            Console.WriteLine("##################");   
            Console.WriteLine("####Marek Petr####");
            Console.WriteLine("##################\n\n");   
            Console.WriteLine();

        // Vstup od uživatele - TO-DO - spatna varianta     
            //Console.WriteLine("Zadejte prvni cislo rady: ")
            //int first = int.Parse(Console.ReadLine());
        // Vstup od uživatele - TO-DO - spravna varianta
            Console.Write("Zadejte prvni cislo rady(cele cislo): ");
            int first;
            while(!int.TryParse(Console.ReadLine(), out first)) {
                Console.Write("Nezadali jste cele cislo. Zadejte znovu prvni cislo rady (cele cislo)");
            }
                Console.Write("Zadejte posledni cislo rady(cele cislo): ");
            int last;
            while(!int.TryParse(Console.ReadLine(), out last)) {
                Console.Write("Nezadali jste cele cislo. Zadejte znovu posledni cislo rady (cele cislo)");
            }
                Console.Write("Zadejte diference rady(cele cislo): ");
            int step;
            while(!int.TryParse(Console.ReadLine(), out step)) {
                Console.Write("Nezadali jste cele cislo. Zadejte znovu prvni cislo rady (cele cislo)");
            }

            // Vypis uzivatelskeho vstupu
            Console.WriteLine();
            Console.WriteLine("##################");
            Console.WriteLine("Prvni cislo rady: {0}", first);
            Console.WriteLine("Posledni cislo rady: {0}", last); 
            Console.WriteLine("Diference: {0}", step);
            Console.WriteLine("##################\n\n");   
            Console.WriteLine();
            Console.WriteLine();
        // logika pro výpis řady - TO-DO


        // Opakování programu
        Console.WriteLine("Pro opakovani programu stisknete klavesu a");
        again = Console.ReadLine();
        }
    }
}