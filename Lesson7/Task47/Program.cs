// Задается двумерный массив размером m×n, заполненный случайными вещественными числами

double[,] InitArray(int row, int col, int minValue, int maxValue, int decimals)
{
    double[,] arr = new double[row, col];
    minValue *= decimals;
    maxValue *= decimals;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue + 1);
            arr[i, j] /= decimals;
        }
    }
    return arr;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());
PrintArray(InitArray(m, n, -9, 9, 10));
