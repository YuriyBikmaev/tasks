// Программа на вход принимает число (N) и выдает таблицу кубов от 1 до N
Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());
for (int i=1; i<=numberN; i++)
{
     Console.Write($"{i*i*i}, ");
}
Console.WriteLine();