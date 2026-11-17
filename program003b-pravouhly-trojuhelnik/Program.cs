Console.Clear();
string again = "a";

while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************************");
    Console.WriteLine("*********** Vykreslení pravoúhlého trojúhelníku ********");
    Console.WriteLine("********************************************************");
    Console.WriteLine("********************* Jan Vébr *************************");
    Console.WriteLine("********************************************************");
    Console.WriteLine();

    Console.Write("Zadejte výšku trojúhelníku :");
    int vyska;
    while (!int.TryParse(Console.ReadLine(), out vyska) || vyska <= 0)
    {
        Console.Write("Nezadali jste kladné celé číslo! Zadejte číslo znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine("==================================");
    Console.WriteLine($"Výška trojúhelníku bude: {vyska}");
    Console.WriteLine("==================================");
    Console.WriteLine();

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
        for (int j = 1; j <= i; j++)
        {
            Console.Write("* ");
        }
        Console.WriteLine(); 
    }

  
    Console.ResetColor();

    // Konec jádra konkrétního algoritmu

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu 'a' a potvrďte klávesou Enter.");
    Console.WriteLine("Jakoukoliv jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";
}