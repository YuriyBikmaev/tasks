// Программа находит сумму натуральных элементов в промежутке от M до N
int SumNumberBetweenMAndN(int current, int number, int result = 0)
{
    if (current > number) return result;
    return  result + current + SumNumberBetweenMAndN(++current, number);
}

Console.Write("Введите число M: ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());
int result = SumNumberBetweenMAndN(numberM, numberN);
Console.WriteLine(result);