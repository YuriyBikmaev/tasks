//Программа на вход принимает числа A и B, затем возводит число A в натуральную степень B
int ExponentNumber(int numA, int numB)
{
    int result=1;
    for (int i=1; i<=numB; i++)
    {
        result = result * numA;
    }
    return result;
}
Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine($"{numberA} в степени {numberB} = {ExponentNumber(numberA, numberB)}");