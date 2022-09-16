// See https://aka.ms/new-console-template for more information
void PrintNumber(int current, int number)
{
    Console.Write(current);
    if (current < number)
    {
        Console.Write(", ");
        PrintNumber(++current, number);
    }
}

Console.Write("Введите число M: ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());
PrintNumber(numberM, numberN);
Console.WriteLine();
