// Задается двумерный массив из целых чисел и рассчитывается среднее арифметическое элементов в каждом столбце

int[,] InitArray(int row, int col, int minValue, int maxValue)
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return arr;
}

void PrintArray(int [,] arr)
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

double [] AvgColArray(int [,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    double [] newArray = new double[col];
    for (int i=0; i<col; i++)
    {
        for (int j=0; j<row; j++)
        {
            newArray[i] += array[j,i];
        }
        newArray[i] /= row;
    }
    return newArray;
}

Console.Write("Введите количество строк массива: ");
int numberRow = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int numberCol = int.Parse(Console.ReadLine());
int [,] myArray = InitArray(numberRow,numberCol, 0, 9);
PrintArray(myArray);
Console.WriteLine(String.Join("; ", AvgColArray(myArray)));