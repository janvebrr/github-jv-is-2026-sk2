Console.Clear();
string again = "a";
// .ToLower() převede vstup na malá písmena
while(again.ToLower() == "a" )
{
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("**********************************************");
    Console.WriteLine("****** Generátor Pseuodonáhodných čísel ******");
    Console.WriteLine("**********************************************");
    Console.WriteLine("************** Jan Vébr **********************");
    Console.WriteLine("**********************************************");
    Console.WriteLine("**********************************************");

    Console.Write("Zadejte počet generovaných čísel (přirozené číslo): ");
    int n;
    while(!int.TryParse(Console.ReadLine(), out n) || n <= 0) {
        Console.Write("Nezadali jste přirozené číslo. Zadejte počet čísel znovu: ");
    }

    // Načtení dolní meze
    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;
    while(!int.TryParse(Console.ReadLine(), out lowerBound)) {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }

    // Načtení horní meze
    Console.Write("Zadejte horní mez (celé číslo větší nebo rovno hodnotě dolní meze): ");
    int upperBound;
    while(!int.TryParse(Console.ReadLine(), out upperBound) || upperBound < lowerBound) {
        Console.Write("Nezadali jste celé číslo větší nebo rovno hodnotě dolní meze. Zadejte horní mez znovu: ");
    }

    // Rekapitulace zadaných vstupních hodnot
    Console.WriteLine();
    Console.WriteLine("=============================");
    Console.WriteLine($"Počet čísel: {n}; Dolní mez: {lowerBound}; Horní mez: {upperBound};");
    Console.WriteLine("=============================");
    Console.WriteLine();
    Console.WriteLine();
    
    // Deklarace a alokace pole v paměti
    int[] myRandNumbs = new int[n];

    // Inicializace generátoru nahodných čísel
    Random myRandNumb = new Random();
    // Random myRandNumb = new Random(50); 

    // Generování náhodných čísel a jejich uložení do pole
    Console.WriteLine("Vygenerovaná pseudonáhodná čísla: ");
    for(int i = 0; i < myRandNumbs.Length; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1);
        Console.Write($"{myRandNumbs[i]}; ");
    }

    // Jádro konkrétního algortimu 
    int min = myRandNumbs[0];
    int max = myRandNumbs[0];
    int posMax= 0;
    int posMin = 0;

    for (int i = 1; i < n; i++)
    {
        if(myRandNumbs[i] > max)
        {
            max = myRandNumbs[i];
            posMax = i;
        }

        if(myRandNumbs[i] < min)
        {
            min = myRandNumbs[i];
            posMin = i;
        }
    
    }
    Console.WriteLine();
    Console.WriteLine("=============================");
    Console.WriteLine($"Maximum: {max}");
    Console.WriteLine($"Pozice prvního maxima: {posMax}");
    Console.WriteLine($"Minimum: {min}");
    Console.WriteLine($"Pozice prvního minima: {posMin}");
    Console.WriteLine("=============================");

    if (max >= 3)
    {
        for(int i = 0; i < max; i++)
        {
            int spaces = 0; 
            int stars = 0;
            if(i < max/2)
            {
                spaces = i;
                stars = max - (2 * i);
            }
        
            else
            {
                //za domácí úkol
            }
            for(int sp = 0; sp < spaces; sp++)
            {
                Console.Write(" ");
            }
            for(int st = 0; st < stars; st++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        } 

    }
    else
    {
    Console.WriteLine("Maaximum je menší než 3, Hodiny se nevypíšou");
    }
    // Konec jádra konkrétního algoritmu


    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";

}   