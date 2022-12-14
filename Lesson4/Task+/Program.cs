// Программа на вход принимает число (высоту елочки) и рисует ее в консоли звездочками
using System.Diagnostics;

void BuildTree (int num)
{
    for(int i=1; i<=num; i++)
    {
        for (int j=1; j<=num+i; j++)
        {
            if (j <=num-i)
            {
                Console.Write(" ");
            }
            else if(j<=num+i-1)
            {
                Console.Write("*");
            }
            
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число (высоту елочки): ");
int number = int.Parse(Console.ReadLine());
long [] arrTime = new long[number];
for (int i=0; i<number; i++)
{
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
    BuildTree(number);
    stopwatch.Stop();
    arrTime[i] = stopwatch.ElapsedMilliseconds;
}

Console.WriteLine("["+String.Join(", ", arrTime)+"]");

Console.WriteLine($"Средняя скорости выполнения алгоритма: {arrTime.Average()}");

