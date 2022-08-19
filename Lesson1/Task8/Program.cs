// Программа на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number >= 2)
{
    int count = 2;
    if ((number % 2) != 0)
    {
        number--;
    }
    while (count<=number)
    {
        if (count<number)
        {
            Console.Write($"{count}, ");
        }
        else
        {
            Console.Write($"{count}");
        }
        count = count + 2;
    }
    
    Console.WriteLine();
} 
else Console.WriteLine("Вы ввели число меньше 2");