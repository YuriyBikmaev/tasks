// Программа показывает количество четных чисел в массиве 

int [] InitArray(int size, int minValue, int maxValue) 
{
    int[] arr = new int[size];
    for(int i=0; i<arr.Length;i++)
    {
        arr[i] = new Random().Next(minValue, maxValue+1);
    }
    return arr;
}

int CheckEvenNumbers(int [] array)
{    
    int result = 0;
    for(int i=0; i<array.Length;i++)
    {
        if (array[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}

Console.Write("Введите размер массива: ");
int sizeArray = int.Parse(Console.ReadLine());
int [] myArray = InitArray(sizeArray, 100, 999);
Console.WriteLine("["+String.Join(", ", myArray) +"]");
Console.WriteLine($"Количество четных чисел = {CheckEvenNumbers(myArray)}");