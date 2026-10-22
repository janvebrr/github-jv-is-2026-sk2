Console.WriteLine("******************************************");

// Vstup počáteční hodnoty - špatně řešený
    Console.Write("Zadejte první číslo řady: ");
    int first = int.Parse(Console.ReadLine()); 
    // Console.Write("Zadejte první číslo řady: ");
    // int first = int.Parse(Console.ReadLine());

    // Vstup počáteční hodnoty - správně řešený
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;
    while(!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte první číslo řady znovu (celé číslo): ");
    }

    // Vstup koncové hodnoty - správně řešený
    Console.Write("Zadejte poslední číslo řady (celé číslo): ");
    int last;
    while(!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte poslední číslo řady znovu (celé číslo): ");
    }

    // Vstup diference s kontrolou kladné hodnoty
    Console.Write("Zadejte diferenci (kladné celé číslo): ");
    int step;
    while(!int.TryParse(Console.ReadLine(), out step) || step <= 0 )
    {
        Console.Write("Diference musí být kladné celé číslo! Zadejte diferenci znovu (kladné celé číslo): ");
    }


// Dotaz směrem k uživateli na opakování