// поиск элемента в массиве 
int [] InitArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for(int i=0; i<arr.Length;i++)
    {
        arr[i] = new Random().Next(minValue, maxValue+1);
    }
    return arr;
}

bool FindElement(int number, int [] array)
{   
    foreach (var item in array)
    {
        if (item == number) return true;
    }
    return false;
}

int [] array = InitArray(5, 0, 1000);
Console.WriteLine("["+String.Join(", ", array) +"]");
int num = int.Parse(Console.ReadLine());
if (FindElement(num, array)) Console.WriteLine("да");
else Console.WriteLine("нет");
