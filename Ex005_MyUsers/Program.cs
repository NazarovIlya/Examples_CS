Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "илья")
{
    Console.Write("Приветствую, мой гениальный господин и создатель, Илья!");
} 
else if(username.ToLower() == "наталья")
{
    Console.Write("Приветствую тебя, любовь моего господина, Наталья!");
}
else 
{ 
    Console.Write("Привет, " );
    Console.Write(username);
    Console.WriteLine("!");
}