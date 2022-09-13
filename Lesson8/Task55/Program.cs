// Программа меняет строки на столбцы в двумерном массиве

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

void SwapColToRowArray(int[,] arr)
{
    if (arr.GetLength(0) == arr.GetLength(1))
    {
        
        for (int i = 0; i < arr.GetLength(0)-1; i++)
        {
            for(int j= i+1; j<arr.GetLength(0); j++)
            {
                int temp = arr[i, j];
                arr[i, j] = arr[j,i];
                arr[j,i] = temp;
            }
            
        }
    }
    else
    {
        Console.WriteLine("Нельзя поменять строки на столбцы");
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
PrintArray(myArray);
Console.WriteLine();
SwapColToRowArray(myArray);
PrintArray(myArray);