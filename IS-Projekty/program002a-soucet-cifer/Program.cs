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
            int number;
            while(!int.TryParse(Console.ReadLine(), out number)) {
                Console.Write("Nezadali jste cele cislo. Zadejte cele cislo: ");
            }
            // Vypis vstupni hodnoty
            Console.WriteLine("===========================");
            Console.WriteLine("Uzivatel zadal: {0}", number);
            Console.WriteLine("===========================\n\n");

            int suma = 0;
            int numberBackup = number;
            int digit;

            while(number >= 10) {
              digit = number % 10; // operator modulu
              number = (number - digit) / 10;
              System.Console.WriteLine("Digit = {0}", digit);
              suma = suma + digit;
            }
            suma = suma + number;
            Console.WriteLine("\n\nSoucet cifer cislo {0} je {1}", numberBackup, suma);

        // Opakování programu
        Console.WriteLine("Pro opakovani programu stisknete klavesu a");
        again = Console.ReadLine();
        }
    }
}