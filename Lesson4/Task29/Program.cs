// Программа создает массив из N элементов, заполненных случайными числами из [a, b) и выводит их на экран
int [] InitArray(int N, int a, int b)
{
    int[] arr = new int[N];
    for(int i=0; i<arr.Length;i++)
    {
        arr[i] = new Random().Next(a, b);
    }
    return arr;
}
Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());
Console.Write("Введите число a: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine("["+String.Join(", ", InitArray(numberN, numberA, numberB))+"]");