// Программа принимает на вход число и выдает сумму цифр в числе
int SumNumber(int num)
{
    int result = 0;
    while (num>0)
    {
        result+= num%10;
        num = num/10;
    }
    return result;
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"{SumNumber(number)}");