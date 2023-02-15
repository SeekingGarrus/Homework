// Принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Ввод с консоли.
Console.Write("Введите число от 1 до 7: ");
int number1 = Convert.ToInt32(Console.ReadLine());
string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
if (number1 > 0 && number1 < 8)
{
    Console.WriteLine($"День недели: {days[number1 - 1]}");
    if (number1 > 5) Console.WriteLine("Этот день - выходной!");
}
else Console.WriteLine("Такого дня недели нет!");

// Еще решение. Рандомный ввод.
int dayNumber = new Random().Next(1, 8);
string[] day = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
string txtResult = "";
if (dayNumber > 5) txtResult = $". Это выходной день!";
else Console.WriteLine($"{dayNumber}-й день недели - это {day[dayNumber - 1]}{txtResult}");


// Эталонное решение. 20 строчек кода - я наверное повторюсь.
int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekday(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("Это не день недели!");
    return false;
}

int weekDay = Prompt("Введите день недели >");
if (ValidateWeekday(weekDay))
{
    if (IsWeekend(weekDay))
    {
        Console.WriteLine("Наконец-то выходной");
    }
    else
    {
        Console.WriteLine("Придется поработать");
    }
}