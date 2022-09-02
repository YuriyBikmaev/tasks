// Программа считает сумму элементов на нечётных позициях в массиве 

int [] InitArray(int size, int minValue, int maxValue) 
{
    int[] arr = new int[size];
    for(int i=0; i<arr.Length;i++)
    {
        arr[i] = new Random().Next(minValue, maxValue+1);
    }
    return arr;
}

int SumNumbersOddPosition(int [] array)
{    
    int result = 0;
    for(int i=1; i<array.Length; i=i+2)
    {
        result+= array[i];
    }
    return result;
}

Console.Write("Введите размер массива: ");
int sizeArray = int.Parse(Console.ReadLine());
int [] myArray = InitArray(sizeArray, -100, 100);
Console.WriteLine("["+String.Join(", ", myArray) +"]");
Console.WriteLine($"Сумма чисел = {SumNumbersOddPosition(myArray)}");