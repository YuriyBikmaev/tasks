// Программа находит сумму чисел трехзанмного числа
int SumRec(int number, int result = 0)
{
    if (number != 0)
    {
       result += number%10 +SumRec(number/10, result);
    }
    return result;
}


int result = SumRec(555);
Console.WriteLine(result);