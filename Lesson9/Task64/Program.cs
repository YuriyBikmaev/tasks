// Программа выводит все натуральные числа в промежутке от M до N
void PrintNumber(int current, int number)
{
    Console.Write(++current);
    if (current < number-1)
    {
        Console.Write(", ");
        PrintNumber(current, number);
    }
}

Console.Write("Введите число M: ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());
PrintNumber(numberM, numberN);
Console.WriteLine();