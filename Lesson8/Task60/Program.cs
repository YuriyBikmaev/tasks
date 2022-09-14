// Программа формирует трехмерный массив с двузначными неповторяющимися элементами и вывод элементы с их индексами

int[,,] InitArray(int x, int y, int z, int minValue, int maxValue)
{
    int[,,] arr = new int[y, x, z];
    for (int i = 0; i < y; i++)
    {
        for (int j = 0; j < x; j++)
        {
            for (int k = 0; k < z; k++)
            {
                arr[i, j, k] = GenerateUniqueElementArray(arr, minValue, maxValue);
            }
        }
    }
    return arr;
}

bool FindNumberInArray(int number, int[,,] array)
{
    foreach (int num in array)
    {
        if (num == number)
            return true;
    }
    return false;
}

int GenerateUniqueElementArray(int[,,] array, int minValue, int maxValue)
{
    int result = new Random().Next(minValue, maxValue + 1);
    if (FindNumberInArray(result, array))
        return GenerateUniqueElementArray(array, minValue, maxValue);
    else
        return result;
}

void PrintArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k})\t");
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine("Введите размеры трехмерного массива");
Console.Write("X = ");
int sizeX = int.Parse(Console.ReadLine());
Console.Write("Y = ");
int sizeY = int.Parse(Console.ReadLine());
Console.Write("Z = ");
int sizeZ = int.Parse(Console.ReadLine());
if (sizeX * sizeY * sizeZ <= 90)
{
    int[,,] myArray = InitArray(sizeY, sizeX, sizeZ, 10, 99);
    PrintArray(myArray);
}
else
{
    Console.WriteLine("Для массива  такой размерности нельзя сформировать уникальные двузначные числа");
}
