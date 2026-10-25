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
    

    // Opakovací dotaz
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stislněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";

}   