using System;
using System.ComponentModel;

class Program {

    static void Main() {
        // chci aby se program opakoval po stisku klavesi "a"
        string again = "a";
        while (again == "a") {
            //Console.Clear();
            Console.WriteLine("#########################################");
            Console.WriteLine("#### Generator pseudonahodnych cisel ####");
            Console.WriteLine("#########################################");   
            Console.WriteLine("############### Marek Petr ##############");
            Console.WriteLine("#########################################\n\n");   
            Console.WriteLine();

            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
            }

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez (celé číslo): ");
            }

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez (celé číslo): ");
            }

            Console.WriteLine("\n\n====================");
            Console.WriteLine("Uživatelský vstup: ");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("====================\n\n");

            // deklarace pole
            int[] myArray = new int[n];
            int positiveCount = 0; // počítadlo kladných čísel
            int negativeCount = 0; // počítadlo záporných čísel

            //priprava pro generovani nahodnyho cisla
            Random randomNumber = new Random();
            int nuly = 0;
            int suda = 0;
            int licha = 0;    

            Console.WriteLine("Nahodna cisla: ");
            
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write(" {0} ", myArray[i]);
                if (myArray[i] > 0)
                    positiveCount++;
                else if (myArray[i] < 0)
                    negativeCount++;
                else 
                    nuly++;

                if (myArray[i] % 2 == 0)
                    suda++;
                else licha++;
            }
            // Výpis výsledků
            Console.WriteLine("\nPočet kladných čísel: {0}", positiveCount);
            Console.WriteLine("Počet záporných čísel: {0}", negativeCount);
            Console.WriteLine("Počet nul: {0}", nuly);

            // Opakování programu
            Console.WriteLine("Pro opakovani programu stisknete klavesu a");
            again = Console.ReadLine();
        }
    }
}
