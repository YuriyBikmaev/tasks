// подсчет количества цифр из интервала [A,B] в массиве 
int [] InitArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for(int i=0; i<arr.Length;i++)
    {
        arr[i] = new Random().Next(minValue, maxValue+1);
    }
    return arr;
}

void SumPairs(int [] array)
{   
    int whole = array.Length/2;
    for(int i=0; i<whole; i++)
    {
        Console.Write($"{array[i]*array[array.Length-i-1]} ");
    }
    if (array.Length % 2 > 0)
    {
        Console.Write($"{array[whole]}");
    }
    Console.WriteLine();
}

Console.Write("Введите размер массива: ");
int sizeArray = int.Parse(Console.ReadLine());
int [] array = InitArray(sizeArray, 1, 9);
Console.WriteLine("["+String.Join(", ", array) +"]");
SumPairs(array);