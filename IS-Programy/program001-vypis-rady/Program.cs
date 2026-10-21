// .ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávání "a" tak i "A"
while(again.ToLower() == "a" )
{
    Console.Clear();
    Console.WriteLine("******************************************");
    Console.WriteLine("*************** Výpis řady ***************");
    Console.WriteLine("******************************************");
    Console.WriteLine("************** Jan Vébr ******************");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");



// Dotaz směrem k uživateli na opakování
Console.WriteLine();
Console.WriteLine();
@@ -23,6 +31,6 @@ více řádkový
Console.Write("Chcete program spustit znovu? ");
again = Console.ReadLine() ?? "";

}    
}   

