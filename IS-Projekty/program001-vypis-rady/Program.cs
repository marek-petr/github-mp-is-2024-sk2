using System;
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

        // Vstup od uživatele - TO-DO            

        // logika pro výpis řady - TO-DO


        // Opakování programu
        Console.WriteLine("Pro opakovani programu stisknete klavesu a");
        again = Console.ReadLine();
        }
    }
}