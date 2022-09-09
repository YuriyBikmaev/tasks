// Программа перевода римских чисел в арабские

int ConvertCharToInt(char num)
{
    switch (num)
    {
        case 'I':
            return 1;
        case 'V':
            return 5;
        case 'X':
            return 10;
        case 'L':
            return 50;
        case 'C':
            return 100;
        case 'D':
            return 500;
        case 'M':
            return 1000;
        default:
            return 0;
    }
}

void ConvertRomanNumeral(string numRoman)
{
    int result = 0;
    for (int i = 0; i < numRoman.Length; i++)
    {
        if (i + 1 < numRoman.Length &&  ConvertCharToInt(numRoman[i]) < ConvertCharToInt(numRoman[i + 1]))
        {
            result -= ConvertCharToInt(numRoman[i]);
        }
        else
        {
            result += ConvertCharToInt(numRoman[i]);
        }
    }
    Console.WriteLine(numRoman + $" -> {result}");
}

Console.WriteLine("Введите римское число:");
string numberRom = Console.ReadLine();
ConvertRomanNumeral(numberRom);