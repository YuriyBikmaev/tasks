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

int SqrtNew (int number)
{
    double left = 0, rigth = Convert.toDouble(number);
    double result = (left + rigth) /2;
    while(rigth - left > 1)
    {
        if(result * result <= number)
        {
            left = result;
        }
        else
        {
            rigth = result;
        }
        result = (left + rigth)/2;
    }
    return Convert.ToInt32(result);
}

Console.Write("Введите целое число: ");
int numberN = int.Parse(Console.ReadLine());
Console.WriteLine($"Целая часть крадратного корня от {numberN} = {IntegerSqrt(numberN)}");
Console.WriteLine($"Целая часть крадратного корня от {numberN} = {SqrtNew(numberN)}");
