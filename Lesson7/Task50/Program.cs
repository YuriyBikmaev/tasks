// Программа на вход принимает программу, которая на вход принимает число и генерирует случайный двумерный массив, и возвращает индексы этого элемента
// или же указание, что такого элемента нет

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
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void FindElementArray(int[,] array, int findNum)
{
    bool yes = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (findNum == array[i, j])
            {
                Console.Write($"[{i + 1}, {j + 1}]  ");
                yes = true;
            }
        }
    }
    if(!yes) 
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    Console.WriteLine();
}

int[,] myArray = InitArray(4, 4, 0, 9);
PrintArray(myArray);

Console.Write("Введите число для поиска в массиве: ");
int findNumber = int.Parse(Console.ReadLine());

FindElementArray(myArray, findNumber);

