Console.Clear();
// Условная классификаци методов

// Группа 1
// Не принимают аргументыи ничего не возвращают

void MethodOne()
{
    Console.WriteLine("Автор ФИО");
}

//MethodOne();      // вызов метода

// Группа 2
// Не принимают аргументыи ничего не возвращают

void MethodTwo(string name, int date)
{
    Console.WriteLine($"Автор {name}, {date}");
}

Console.WriteLine("Введите свое имя: ");
string authorName = Console.ReadLine();
Console.WriteLine("Введите дату: ");
int date = Convert.ToInt32(Console.ReadLine());

MethodTwo(name: authorName, date: date);



// Группа 3

// Группа 4
// Принимают на вход данные в виде аргументов и возвращают результат
