using static System.Console;

string[] MakeNewString(string[] text)
{
    string[] newArray = new string[text.Length -3];
    for (int i = 0; i < text.Length -3; i++)
    {
        newArray[i] = text[i];
    }
    return newArray;
}

string[] array = new string[6] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
Console.Write($" [{String.Join(", ", array)}] ->");
string[] newArray = MakeNewString(array);
Console.Write($" [{String.Join(", ", newArray)}]");

