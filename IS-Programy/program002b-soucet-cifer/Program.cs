Console.Clear();
string again = "a";

while (again.ToLower() == "a")
{
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("**********************************************");
    Console.WriteLine("******* Ciferný součet a součin **************");
    Console.WriteLine("**********************************************");
    Console.WriteLine("************** Jan Vébr **********************");
    Console.WriteLine("**********************************************");

    Console.Write("Zadejte celé číslo: ");
    int cislo;
    while (!int.TryParse(Console.ReadLine(), out cislo))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte hodnotu znovu: ");
    }

    string textCislo = Math.Abs(cislo).ToString(); 
    int suma = 0;
    int soucin = 1;

    foreach (char znak in textCislo)
    {
        int cifra = (int)char.GetNumericValue(znak);   
        suma += cifra;
        soucin *= cifra;
    }
    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"Původní číslo: {cislo}");
    Console.WriteLine($"Ciferný součet: {suma}");
    Console.WriteLine($"Ciferný součin: {soucin}");
    Console.WriteLine("====================================");
    Console.WriteLine();

    Console.WriteLine("Pro opakování programu stiskněte klávesu a a potvrďte Enter.");
    Console.WriteLine("Jakoukoli jinou klávesou program ukončíte.");
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";
}