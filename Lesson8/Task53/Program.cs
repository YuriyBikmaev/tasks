// Программа меняет первую и последнюю строку двумерного массива местами

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

void SwapLineArray(int[,] arr)
{
    int j = arr.GetLength(0)-1;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
       int temp = arr[0, i];
       arr[0,i]= arr[j,i];
       arr[j,i] = temp;
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
SwapLineArray(myArray);
PrintArray(myArray);
