// Программа находит произведение матриц

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


int[,] MatrixMultiplication(int[,] oneArr, int[,] twoArr)
{
    int rowM1 = oneArr.GetLength(0);
    int colM1 = oneArr.GetLength(1);
    int colM2 = twoArr.GetLength(1);
    int[,] result = new int[rowM1, colM2];
    for (int i = 0; i < rowM1; i++)
    {
        for (int j = 0; j < colM2; j++)
        {
            for (int k = 0; k < colM1; k++)
            {
                   result[i, j] += oneArr[i, k] * twoArr[k, j];
            }
        }
    }
    return result;
}

Console.Write("Введите количество строк первой матрицы: ");
int rowMatrix1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int colMatrix1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк второй матрицы: ");
int rowMatrix2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int colMatrix2 = int.Parse(Console.ReadLine());
int[,] oneMatrix = InitArray(rowMatrix1, colMatrix1, 0, 9);
int[,] twoMatrix = InitArray(rowMatrix2, colMatrix2, 0, 9);

Console.WriteLine();
Console.WriteLine("Первая матрица:");
PrintArray(oneMatrix);

Console.WriteLine();
Console.WriteLine("Вторая матрица:");
PrintArray(twoMatrix);

if (colMatrix1 == rowMatrix2)
{
    int[,] resultMatrix = MatrixMultiplication(oneMatrix, twoMatrix);
    Console.WriteLine();
    Console.WriteLine("Произведение матриц:");
    PrintArray(resultMatrix);
}
else
    Console.WriteLine(
        "Количество столбцов первой матрицы должно быть ровно количеству строк второй матрицы!"
    );
