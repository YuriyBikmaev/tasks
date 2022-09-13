// See https://aka.ms/new-console-template for more information

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

int[] InitArray1(int col, int minValue, int maxValue)
{
    int[] arr = new int[col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
       arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

void DictionaryCountArray(int [] arr)
{
    int count = 1;
    for (int i = 0; i < arr.Length-1; i++)
    {
        if (arr[i] != arr[i+1])
        {
            Console.WriteLine($"{arr[i]} встречается {count}");
            count = 1;
        }
    
        else
        {
            count++;
        }
    }
    Console.WriteLine($"{arr[arr.Length-1]} встречается {count}");
}

void SortBuble(int [] array)
{   
    int temp = 0;
    for(int i=0; i<array.Length; i++)
    {
        for(int j=i+1; j<array.Length; j++)
        {
            if (array[i]>array[j])
            {
                temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
        }
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}\t");
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());
int[,] myArray = InitArray(m, n, 1, 9);
int[] myArray1 = InitArray1(n, 1, 9);

PrintArray(myArray1);
Console.WriteLine();
DictionaryCountArray(myArray1);
Console.WriteLine();