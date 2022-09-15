// Программа заполняет по спирали двумерный массив любой размерности

int[,] InitArray(int row, int col, int beginNumber)
{
    int[,] result = new int[row, col];
    SpiralFillArrayTopRigth(result, 0, 0, row - 1, col - 1, beginNumber);
    return result;
}

void SpiralFillArrayTopRigth(int[,] array, int y1, int x1, int y2, int x2, int beginNum)
{

    for (int i = x1; i <= x2 - 1; i++)
    {
        array[y1, i] = beginNum++;
    }
    for (int i = y1; i <= y2; i++)
    {
        array[i, x2] = beginNum++;
    }
    if (x2 - x1 > 0)
    {
        SpiralFillArrayBottomLeft(array, y1 + 1, x1, y2, x2 - 1, beginNum);
    }

}

void SpiralFillArrayBottomLeft(int[,] array, int y1, int x1, int y2, int x2, int beginNum)
{

    for (int i = x2; i >= x1; i--)
    {
        array[y2, i] = beginNum++;
    }
    for (int i = y2 - 1; i >= y1; i--)
    {
        array[i, x1] = beginNum++;
    }
    if (y2 - y1 > 0)
    {
        SpiralFillArrayTopRigth(array, y1, x1 + 1, y2 - 1, x2, beginNum);
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
int rowNumber = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int colNumber = int.Parse(Console.ReadLine());
int[,] myArray = InitArray(rowNumber, colNumber, 1);

Console.WriteLine();
PrintArray(myArray);
