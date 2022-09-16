// Программа на проверку правильной последовательности скобок

string CheckingBrackets(string str)
{
    var brackets = new Stack<char>();
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == '{' || str[i] == '(' || str[i] == '[')
        {
            brackets.Push(str[i]);
        }

        else if (str[i] == '}' || str[i] == ')' || str[i] == ']')
        {
            if (brackets.Count > 0)
            {
                char prevChar;
                switch (str[i])
                {
                    case '}': nextChar = '{'; break;
                    case ')': nextChar = '('; break;
                    case ']': nextChar = '['; break;
                    default: nextChar = ' '; break;
                }
                if (nextChar == brackets.Pop())
                {
                    continue;
                }
            }
            else return "Последовательность скобок неверная";
        }
    }
    if (brackets.Count == 0)
    return "Последовательность скобок верная";
    else return "Последовательность скобок неверная";
}

Console.WriteLine("Введите последвательность скобок");
string inputString = Console.ReadLine();
Console.WriteLine(CheckingBrackets(inputString));