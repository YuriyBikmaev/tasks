// Программа перевода римских чисел в арабские
Console.WriteLine("Введите римское число:");
string number = Console.ReadLine();
int size = number.GetLength() - 1;

int CheckChar(char num)
{
    switch (num)
    {
        case "I":
            return 1;
        case "V":
            return 5;
        case "X":
            return 10;
        case "L":
            return 50;
        case "C":
            return 100;
        case "M":
            return 1000;
        default:
            return 0;
    }
}

int ConvertNumber(string num)
{
    for (int i = size; i >= 0; i--) 
    {
        
    }
}
