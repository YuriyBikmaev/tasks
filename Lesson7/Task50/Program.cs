// Программа на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет

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

void FindElementArray(int [,] array, int findRow, int findCol)
{
    if (findRow>array.GetLength(0) || findRow<1 || findCol>array.GetLength(1) || findCol<1)
    {
        Console.WriteLine("Такого элемента нет");
    }
    else
    {
        Console.WriteLine($"{array[findRow-1,findCol-1]}");
    }
}

int [,] myArray = InitArray(4,4, 0, 9);
PrintArray(myArray);

Console.Write("Введите номер строки массива: ");
int numberRow = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца массива: ");
int numberCol = int.Parse(Console.ReadLine());

FindElementArray(myArray, numberRow, numberCol);

