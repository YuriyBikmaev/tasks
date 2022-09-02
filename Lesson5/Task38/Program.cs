// Программа считает разницу между вещественными максимальным и минимальным числами в массиве 

double [] InitArrayDouble(int size, double maxValue) 
{
    double [] arr = new double[size];
    for(int i=0; i<arr.Length;i++)
    {
        arr[i] = new Random().NextDouble() * maxValue;
    }
    return arr;
}

double MaxArrayDouble (double [] array)
{    
    double result = array[0];
    for(int i=1; i<array.Length; i++)
    {
        if (result<array[i])
        {
            result = array[i];
        }
    }
    return result;
}

double MinArrayDouble (double [] array)
{    
    double result = array[0];
    for(int i=1; i<array.Length; i++)
    {
        if (result>array[i])
        {
            result = array[i];
        }
    }
    return result;
}

Console.Write("Введите размер массива: ");
int sizeArray = int.Parse(Console.ReadLine());
double [] myArray = InitArrayDouble(sizeArray, 10);
Console.WriteLine("["+String.Join(", ", myArray) +"]");
Console.WriteLine($"Разница чисел = {MaxArrayDouble(myArray) - MinArrayDouble(myArray)}");