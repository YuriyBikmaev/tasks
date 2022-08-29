// Программа на вход принимает число (высоту елочки) и рисует ее в консоли звездочками
void BuildTree (int num)
{
    for(int i=1; i<=num; i++)
    {
        for (int j=1; j<=num+i; j++)
        {
            if (j <=num-i)
            {
                Console.Write(" ");
            }
            else if(j<=num+i-1)
            {
                Console.Write("*");
            }
            
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число (высоту елочки): ");
int number = int.Parse(Console.ReadLine());
BuildTree(number);
