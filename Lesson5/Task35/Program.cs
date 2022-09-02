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

int CheckElement(int minValue, int maxValue, int [] array)
{   
    int result = 0;
    foreach (var item in array)
    {
        if (item > minValue-1 && item < maxValue+1) result++; 
    }
    return result;
}

int [] array = InitArray(123, 0, 999);
Console.WriteLine("["+String.Join(", ", array) +"]");
Console.WriteLine($"{CheckElement(10, 99, array)}");