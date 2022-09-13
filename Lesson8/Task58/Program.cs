// See https://aka.ms/new-console-template for more information

int[,] InitArray(int size, int minValue, int maxValue)
{
    int[,] arr = new int[size, size];
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

int MatrixMultiplicationStep (int curPosition, int[,] array, int col)
{
    int size = array.GetLength(0);
    int result = 0;
    for (int i = 0; i < size; i++)
    {
        result+= curPosition* array[i,col];
    }
    return result;
}

int[,] MatrixMultiplication(int[,] oneArr, int[,] twoArr)
{
    int size = oneArr.GetLength(0);
    int[,] result = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            result[i,j] = MatrixMultiplicationStep(oneArr[i,j], twoArr, j);
        }
    }
    return result;
}

Console.Write("Введите размер матрицы: ");
int sizeMatrix = int.Parse(Console.ReadLine());
int[,] oneMatrix = InitArray(sizeMatrix, 1, 9);
int[,] twoMatrix = InitArray(sizeMatrix, 1, 9);

Console.WriteLine();
Console.WriteLine("Первая матрица:");
PrintArray(oneMatrix);

Console.WriteLine();
Console.WriteLine("Вторая матрица:");
PrintArray(twoMatrix);

int[,] resultMatrix = InitArray(sizeMatrix, 1, 9);
Console.WriteLine();
Console.WriteLine("Произведение матриц:");
PrintArray(twoMatrix);
