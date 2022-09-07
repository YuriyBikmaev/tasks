// Подсчет чисел больше 0, введенных пользователем с клавиатуры
int CountGreaterNull(int M)
{
    int result = 0;
    for (int i = 0; i < M; i++)
    {
        Console.Write("Введите число: ");
        if (int.Parse(Console.ReadLine()) > 0)
            result++;
    }
    return result;
}

int[] InitArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите число: ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

int CountGraterNullArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            result++;
    }
    return result;
}

Console.Write("Какое количество чисел будет вводиться? ");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine($"Чисел больше нуля: {CountGreaterNull(numberM)}");
int [] myArray = InitArray(numberM);
Console.WriteLine($"Чисел больше нуля: {CountGraterNullArray(myArray)}");
