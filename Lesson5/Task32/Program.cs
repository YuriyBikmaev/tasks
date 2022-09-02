// Программа считает сумму отрицательных и положительных элементов в массиве 
int [] InitArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for(int i=0; i<arr.Length;i++)
    {
        arr[i] = new Random().Next(minValue, maxValue+1);
    }
    return arr;
}

int [] Replacement(int [] array)
{    
    int [] result = new int[array.Length];
    for(int i=0; i<array.Length;i++)
    {
        result[i]=array[i]*-1;
    }
    return result;
}

int [] array = InitArray(12, -9, 9);
int [] result = Replacement(array);
Console.WriteLine("["+String.Join(", ", array) +"]");
Console.WriteLine("["+String.Join(", ", result) +"]");
