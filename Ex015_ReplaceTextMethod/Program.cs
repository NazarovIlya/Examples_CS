
Console.Clear();
Console.WriteLine("Hello, World!");
string? userText = Console.ReadLine();
if (userText == null) userText = "";
string ReplaceText(string text)
{

    return text;
}

string newText = ReplaceText(userText);
Console.WriteLine($"{userText} --> {newText}");
