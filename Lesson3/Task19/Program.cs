// Программа на вход принимает пятизначное число и проверяет, является ли оно палиндромом
Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
if (number>9999 && number<100000)
{
    int numberLast2 = number%100;
    if ((number/1000) == ((numberLast2%10)*10+numberLast2/10))
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом");
    }
}
else 
{
    Console.WriteLine($"Число {number} не является пятизначным");
}
