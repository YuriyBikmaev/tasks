// Программа выводит все натуральные числа в промежутке от M до N
string PrintNumberFromMToN(int current, int number, string result = "")
{
    if (current == number) return result + current;
    return result + current +", "+ PrintNumberFromMToN(++current, number);
}

Console.Write("Введите число M: ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());
string result = PrintNumberFromMToN(numberM, numberN);
Console.WriteLine(result);