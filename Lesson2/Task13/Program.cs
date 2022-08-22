// Программа выводит третью цифру числа с конца или сообщает что третьей цифры нет

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number>99)
{
    Console.WriteLine($"{number} -> {(number%1000)/100}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}