// Программа сортирует по убыванию элементы каждой строки в двумерном массиве

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

void SortBubbleArray(int[,] array)
{
    int temp = 0;
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                if (array[k, i] < array[k, j])
                {
                    temp = array[k, j];
                    array[k, j] = array[k, i];
                    array[k, i] = temp;
                }
            }
        }
    }

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

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());
int[,] myArray = InitArray(m, n, 1, 9);

Console.WriteLine();
Console.WriteLine("Исходный массив:");
PrintArray(myArray);

Console.WriteLine();
Console.WriteLine("Отсортированный массив:");
SortBubbleArray(myArray);
PrintArray(myArray);