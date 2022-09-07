int[,] InitArray(int row, int col)
{
    int[,] arr = new int[row, col];
    int k = 1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = k++;
        }
    }
    return arr;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int [] SpiralDetour(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    int count = 0;
    int [] resultArray = new int[row*col];
    PrintBottomRight(array, resultArray, 0, 0, col - 1, row - 1, count);
    return resultArray;
}

void PrintTopLeft(int[,] oldArr, int[] newArr, int x1, int y1, int x2, int y2, int k)
{
    for (int i = x2; i >= x1; i--)
    {
        newArr[k++] = oldArr[y1, i];
    }

    for (int j = y1 + 1; j <= y2; j++)
    {
        newArr[k++] = oldArr[j, x1];
    }

    if (x2 - x1 > 0)
    {
        PrintBottomRight(oldArr, newArr, x1 + 1, y1 + 1, x2, y2, k);
    }
}

void PrintBottomRight(int[,] oldArray, int[] newArray, int x1, int y1, int x2, int y2, int k)
{
    for (int i = x1; i <= x2; i++)
    {
        newArray[k++] = oldArray[y2, i];
    }

    for (int j = y2 - 1; j >= y1; j--)
    {
       newArray[k++] = oldArray[j, x2];
    }

    if (x2 - x1 > 0)
    {
        PrintTopLeft(oldArray, newArray, x1, y1, x2-1, y2-1, k);
    }
}

int[,] myArray = InitArray(3, 3);
PrintArray(myArray);
int[] newMyArray = SpiralDetour(myArray);
Console.WriteLine();
Console.WriteLine(String.Join(" ", newMyArray));
