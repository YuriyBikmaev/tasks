// Программа на вход принимает трехзначное число, а на выходе показывает вторую цифру этого числа

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if (number>99 && number<1000)
{
    Console.WriteLine($"{number} -> {(number%100)/10}");
}
else
{
    Console.WriteLine($"Число {number} не является трехначным");
}