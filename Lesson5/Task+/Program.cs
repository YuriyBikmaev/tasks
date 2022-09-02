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

void SortBuble(int [] array)
{   
    int temp = 0;
    for(int i=0; i<array.Length; i++)
    {
        for(int j=i+1; j<array.Length; j++)
        {
            if (array[i]<array[j])
            {
                temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
        }
    }
}

Console.Write("Введите размер массива: ");
int sizeArray = int.Parse(Console.ReadLine());
int [] firstArray = InitArray(sizeArray, -9, 9);
Console.WriteLine("["+String.Join(", ", firstArray) +"]");
SortBuble(firstArray);
Console.WriteLine("["+String.Join(", ", firstArray) +"]");