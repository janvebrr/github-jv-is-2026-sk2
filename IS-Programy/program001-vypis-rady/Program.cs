Console.WriteLine("Přidej první hodnotu");
List<int> numbers = new List<int>();
bool validInput = false;
do
{
if (int.TryParse(Console.ReadLine(), out int first))
{
    numbers.Add(first);
    validInput = true;
}
else
{
    Console.WriteLine("Varování: zadej platné celé číslo.");
}
} while (validInput == false);
do
{
Console.WriteLine("Přidej druhou hodnotu");
if (int.TryParse(Console.ReadLine(), out int step))
{
    numbers.Add(step);
validInput = true;
}
else
{
    Console.WriteLine("Varování: zadej platné celé číslo.");
}
} while (validInput == false);
do
{
Console.WriteLine("Přidej třetí hodnotu");
if (int.TryParse(Console.ReadLine(), out int last))
{
    numbers.Add(last);
    validInput = true;
}
else
{
    Console.WriteLine("Varování: zadej platné celé číslo.");
}
} while (validInput == false);
for (int i = numbers[0]; i <= numbers[2]; i += numbers[1])
{
            Console.WriteLine(i);
}
