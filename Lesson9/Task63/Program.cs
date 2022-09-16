// See https://aka.ms/new-console-template for more information
void PrintNumber(int number, int current = 1)
{
    Console.Write(current);
    if (current < number)
    {
        Console.Write(", ");
        PrintNumber(number, ++current);
    }
}

Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());
PrintNumber(numberN);
Console.WriteLine();