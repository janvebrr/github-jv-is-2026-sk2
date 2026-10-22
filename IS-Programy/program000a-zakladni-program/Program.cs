
// jako první si připravíme smyčku pro opakování programu

Console.Clear();
string again = "a";
// .ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávání "a" tak i "A"
while(again.ToLower() == "a" )
{
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("******************************************");
    Console.WriteLine("*************** Výpis řady ***************");
    Console.WriteLine("******************************************");
    Console.WriteLine("**************   Jan Vébr   **************");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");

    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int aaa;
    while(!int.TryParse(Console.ReadLine(), out aaa))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte první číslo řady znovu (celé číslo): ");
    }

    // Vstup koncové hodnoty - správně řešený
    Console.Write("Zadejte poslední číslo řady (celé číslo): ");
    int bbb;
    while(!int.TryParse(Console.ReadLine(), out bbb))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte poslední číslo řady znovu (celé číslo): ");
    }
    Console.WriteLine();
    Console.WriteLine("==================================");
    Console.WriteLine($"První číslo: {aaa}; Poslední číslo: {bbb}");
    Console.WriteLine("==================================");
    Console.WriteLine();

    //Jádro Algoritmu pro výpis řady
    
    //Konec jádra Algoritmu


    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stislněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";

}  