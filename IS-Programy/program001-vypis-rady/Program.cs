
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
Console.WriteLine("************** Jan Vébr ******************");
Console.WriteLine("******************************************");
Console.WriteLine("******************************************");
    

    // Vstup počáteční hodnoty - špatně řešený
    Console.Write("Zadejte první číslo řady: ");
    int first = int.Parse(Console.ReadLine()); 


// Dotaz směrem k uživateli na opakování