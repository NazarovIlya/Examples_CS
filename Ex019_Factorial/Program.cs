int GetUserInputInt(string userInputStr)
{
    Console.WriteLine(userInputStr);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double GetFactorial(int number)
{
    if (number == 0) return 1;
    else if (number == 1) return 1;
    else return number * GetFactorial(number - 1);
}


Console.Clear();
int numF = GetUserInputInt("Факториал какого числа необходимо найти? ");
double fact = GetFactorial(numF);
Console.WriteLine($"Факотриал числа {numF} равен {fact}");