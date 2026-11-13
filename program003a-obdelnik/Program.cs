Console.Clear();
string again = "a";
// .ToLower() převede vstup na malá písmena
while(again.ToLower() == "a" )
{
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("**********************************************");
    Console.WriteLine("*************** Název programu ***************");
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
    Console.WriteLine($"První hodnota: {aaa}; Další hodnota: {bbb}");
    Console.WriteLine("==================================");
    Console.WriteLine();

    // Jádro konkrétního algortimu 
    

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