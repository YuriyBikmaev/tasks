// Программа на вход принимает целочисленное значение и выдает целую часть квадратного корня введенного числа

int IntegerSqrt(int number)
{
    double result = number / 2;
    while (result * result > number)
    {
        result /= 2;
    }
    while (number > result * result && number > result * result + result + result)
    {
        result++;
    }

    return Convert.ToInt32(result);
}

Console.Write("Введите целое число: ");
int numberN = int.Parse(Console.ReadLine());
Console.WriteLine($"Целая часть крадратного корня от {numberN} = {IntegerSqrt(numberN)}");
