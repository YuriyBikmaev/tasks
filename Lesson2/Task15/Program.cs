// Программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.Write("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());
if (number > 0 && number < 8)
{
    if (number>5)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine($"{number} дня недели не существует");
}