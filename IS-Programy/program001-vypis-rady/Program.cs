// jednořádkový 
/* 
Toto je více řádkový 
komentář
*/
// zde bude smyčka

string again = "a";
// .ToLower() převede vstup na malá písmena
while(again.ToLower() == "a" )
{
    Console.Clear();
    Console.WriteLine("******************************************");
    Console.WriteLine("*************** Výpis řady ***************");
    Console.WriteLine("******************************************");
    Console.WriteLine("*************** Jan Vébr *****************");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");

    // Vstup počáteční hodnoty - špatně řešený
    // Console.Write("Zadejte první číslo řady: ");
    // int first = int.Parse(Console.ReadLine()); 

    // Vstup první hodnoty
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;
    while(!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte první číslo řady znovu (celé číslo): ");
    }

    // Vstup poslední hodnoty
    Console.Write("Zadejte poslední číslo řady (celé číslo): ");
    int last;
    while(!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte poslední číslo řady znovu (celé číslo): ");
    }

    // Vstup diference s kontrolou
    Console.Write("Zadejte diferenci (kladné celé číslo): ");
    int step;
    while(!int.TryParse(Console.ReadLine(), out step) || step <= 0 )
    {
        Console.Write("Diference musí být kladné celé číslo! Zadejte diferenci znovu (kladné celé číslo): ");
    }


    // Jádro algortimu pro výpis řady
    Console.WriteLine("Výpis číselné řady: ");

    if(first <= last)
    {
        int current = first;
        while(current <= last) {
            Console.WriteLine(current);
            
            // Console.Write($"{current}; ");
            
            // current = current + step;
            current += step;
        }
    }
    else
    {
        Console.WriteLine("Nelze vypsat řadu!");
        Console.WriteLine("První číslo je větší než poslední.");
        Console.WriteLine("Tento program umí vypsat pouze vzestupnou řadu ");
    }

    // Opakovací dotaz
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stislněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";

}   