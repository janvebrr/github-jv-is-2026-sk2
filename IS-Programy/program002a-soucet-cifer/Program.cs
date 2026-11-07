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
    int cislo;
    while(!int.TryParse(Console.ReadLine(), out cislo))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte první hodnotu znovu (celé číslo): ");
    }

    
    
    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("==================================");
    // Výpis zadaných hodnot do jednoho řádku
    Console.WriteLine($"První hodnota: {cislo}");
    Console.WriteLine("==================================");
    Console.WriteLine();

    // Jádro konkrétního algortimu 
    int zaloha = cislo;
    int suma = 0;
    int cifra;
    int soucin = 1;

    if (cislo < 0)
    {
        cislo = -cislo;
    }

    if (cislo == 0)
    {
        suma = 0;
        soucin = 0;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Průběh rozkladu čísla na cifry (zprava doleva):");

        
        while (cislo > 0)
        {
            cifra = cislo % 10;            
            suma = suma + cifra; 
            soucin = soucin * cifra;             
            cislo = cislo / 10;           
        }
    }
     

    
    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"Původní číslo:  {zaloha}, ciferný součet: {suma} a součin {soucin} ");
    Console.WriteLine("====================================");
    Console.WriteLine();



    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";

}   