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

    int kladnecisla = 0;
    int zapornecisla = 0;
    int nulove = 0;
    int sude = 0;
    int liche = 0;



    // Jádro konkrétního algortimu 
    int[] myRandNumbs = new int[n];
    Random myRandNumb = new Random();
    Console.WriteLine("Vygenerovaná pseudonáhodná čísla: ");
    for(int i = 0; i < myRandNumbs.Length; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1);
        Console.Write($"{myRandNumbs[i]}; ");
          if(myRandNumbs[i] < 0)
          {
            zapornecisla++;
          }
        else if(myRandNumbs[i] > 0)
        {
            kladnecisla++;
        }
        else
        {
            nulove++;    
        }    
        if (myRandNumbs[i] % 2 == 0)
        sude ++;
        else 
        liche++;
    }
    Console.WriteLine();
    Console.WriteLine("=============================");
    Console.WriteLine($"Počet záporných čísel: {zapornecisla}");
    Console.WriteLine($"Počet kladných čísel: {kladnecisla}");
    Console.WriteLine($"Počet nul: {nulove}");
    Console.WriteLine("=============================");
    Console.WriteLine($"Počet sudých čísel: {sude}");
    Console.WriteLine($"Počet lichých čísel {liche}");
    Console.WriteLine("=============================");
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