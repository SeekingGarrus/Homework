// Выводит третью цифру заданного числа или сообщает, что третьей цифры нет
int value = new Random().Next(1, 1000);
if (value > 100 && value < 1000) { Console.WriteLine($"Третья цифра числа {value} это {((value % 100) % 10)}."); }
else Console.WriteLine($"Число {value} не является трехзначным!");

// еще решение, опять замудреное
int number1 = new Random().Next(1, 1000);
if (number1 / 100 > 0) Console.WriteLine("Третьей цифрой числа " + number1 + " является цифра " + ((number1 % 10) - ((number1 % 10) / 10 * 10)));
else Console.WriteLine($"У числа {number1} нет третьей цифры!");


// Эталонное решение - 17 строчек вашего кода против моих 3-х. Вообще не эффективно!
int Prompt(string message) // переменные называются со строчной буквы, в одно слово, каждый новый корень начинается с заглавной буквы кроме первого корня
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int GetThirdRank(int number) //переменные называются со строчной буквы
{
    while (number > 999)
    {
        number /= 10; // первый раз вижу
    }
    return number % 10;
}
bool ValidateNumber(int number) //переменные называются со строчной буквы
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}

int number  = Prompt("Введите число > "); // стрелка вместо равно зачем?
if (ValidateNumber(number))
{
Console.WriteLine(GetThirdRank(number));
}