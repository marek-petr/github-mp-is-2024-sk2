using System;

class Program {
    static void Main() {
        // chci aby se program opakoval po stisku klavesi "a"
        string again = "a";
        while (again == "a") {
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

            // priprava pro generovani nahodnyho cisla
            Random randomNumber = new Random();

            Console.WriteLine("Nahodna cisla: ");
            
            for(int i = 0; i < n; i++) {
                myArray[i] = randomNumber.Next(dm, hm);
                Console.WriteLine("{0}; ", myArray[i]);
            }

            int max = myArray[0];
            int min = myArray[0];
            int maxPos = 0;
            int mixPos = 0;

            for (int i = 1; i < n; i++) {
                if (myArray[i] > max) {
                    max = myArray[i];
                    maxPos = i;
                }
                if (myArray[i] < min) {
                    min = myArray[i];
                    mixPos = i;
                }
            }

            Console.WriteLine("\nMaximální číslo je: {0} na pozici: {1}", max, maxPos);
            Console.WriteLine("Minimální číslo je: {0} na pozici: {1}\n", min, mixPos);


            // Opakování programu
            Console.WriteLine("Pro opakovani programu stisknete klavesu a");
            again = Console.ReadLine();
        }
    }
}
