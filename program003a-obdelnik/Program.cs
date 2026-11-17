Console.Clear();
string again = "a";
// .ToLower() převede vstup na malá písmena
while(again.ToLower() == "a" )
{
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("**********************************************");
    Console.WriteLine("*************** Vykreslení obdelníku ***************");
    Console.WriteLine("**********************************************");
    Console.WriteLine("************** Jan Vébr **********************");
    Console.WriteLine("**********************************************");
    Console.WriteLine("**********************************************");

    // Vstup první hodnoty
    Console.Write("Zadejte první hodnotu (celé číslo): ");
    int vyska;
    while(!int.TryParse(Console.ReadLine(), out vyska))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte první hodnotu znovu (celé číslo): ");
    }

    // Vstup další hodnoty
    Console.Write("Zadejte další hodnotu (celé číslo): ");
    int sirka;
    while(!int.TryParse(Console.ReadLine(), out sirka))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte další hodnotu znovu (celé číslo): ");
    }

    
    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("==================================");
    // Výpis zadaných hodnot do jednoho řádku
    Console.WriteLine($"Vyska obdelníku bude {vyska} a šířka {sirka}");
    Console.WriteLine("==================================");
    Console.WriteLine();

    // Jádro konkrétního algortimu 
    
 for (int i = 1; i <= vyska; i++)
    {
         if(i % 2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        for (int j = 1; j <= sirka; j++)
        {
            Console.Write("* ");
             System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100)); 
        }
        Console.WriteLine();
    }
     Console.ResetColor();
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