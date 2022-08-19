// Программа на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.Write ("Введите число: ");
int number = int.Parse(Console.ReadLine());
if ((number % 2) == 0)
{
    Console.WriteLine("Четное");
}
else 
{
    Console.WriteLine("Нечетное");
}

