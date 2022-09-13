// Программа находит строку в двумерном массиве с минимальной суммой элементов

int[,] InitArray(int row, int col, int minValue, int maxValue)
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int SumRowArray(int[,] array, int row)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        result += array[row, i];
    }
    return result;
}

void FindMinSumRowArray(int[,] array)
{
    int result = 0;
    int tempSum = SumRowArray(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sumRow = SumRowArray(array, i);
        if (tempSum > sumRow)
        {
            tempSum = sumRow;
            result = i;
        }
    }
    Console.WriteLine($"{result+1} строка");
}


Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());
int[,] myArray = InitArray(m, n, 0, 9);

Console.WriteLine();
PrintArray(myArray);
Console.WriteLine();
FindMinSumRowArray(myArray);