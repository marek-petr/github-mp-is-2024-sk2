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

            System.Console.WriteLine("\nZadejte text pro analyzu:");
            string myText = Console.ReadLine();
            string samohlasky = "aáeéioóuůúyý";
            string souhlasky = "bcčdďfghjklmnňpqrřsštťvwxzž";
            string cislice = "0123456789";
            foreach(char znak in myText) {
                if(souhlasky.Contains)
            };
            System.Console.WriteLine(myText);


        // Opakování programu
        Console.WriteLine("Pro opakovani programu stisknete klavesu a");
        again = Console.ReadLine();
        }
    }
}