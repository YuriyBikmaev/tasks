// See https://aka.ms/new-console-template for more information
int FunctionAkkerman(int m, int n)
{
    if (m==0) return n+1;
    else if (m>0 && n==0) return FunctionAkkerman(m-1, 1);
    else return FunctionAkkerman(m-1, FunctionAkkerman(m, n -1));
}

Console.Write("Введите значение m: ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Введите значение n: ");
int numberN = int.Parse(Console.ReadLine());
Console.WriteLine($"Результат расчета по функции Аккермана: {FunctionAkkerman(numberM, numberN)}");
