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

int [] SumPositiveAndNegative(int [] array)
{
    int [] result = new int[2];
    
    for(int i=0; i<array.Length;i++)
    {
        if (array[i]>0) 
        {
            result[0]+=array[i];
        }
        else
        {
            result[1]+=array[i];
        }
    }
    return result;
}

Console.WriteLine("["+String.Join(", ", InitArray(12, -9, 9))+"]");
Console.WriteLine("["+String.Join(", ", SumPositiveAndNegative(InitArray(12, -9, 9)))+"]");