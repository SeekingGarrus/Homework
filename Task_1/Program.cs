// Принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int value1 = new Random().Next(100, 1000);
Console.WriteLine($"Вторая цифра числа {value1} это {((value1 / 10) % 10)}");

// или так
int number1 = new Random().Next(100, 1000);
Console.WriteLine("Вторая цифра числа " + number1 + " это " + ((number1 % 100) / 10));

// ещё так, замудрёно
int num = new Random().Next(100, 1000);
Console.WriteLine("Вторая цифра числа " + num + " это " + ((num / 10) - ((num / 10) / 10 * 10)));


// Эталонное решение - 12 строк кода против моих 2-х. Как говорит наш преподаватель "Если смотреть со стороны оптимизации - не эффективно".
int Prompt(string message) // Вводить целую фукцию чтобы ввести 3-значное число??? Достаточно 2-х строчек.
{
    System.Console.Write(message); // про добавление System. еще не говорили
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);// две строки можно было представить одной
    return result;
}

int number = Prompt("Введите трёхзначное число > ");

if (number < 100 || number >= 1000)                  // почему здесь or вместо and?
{
    Console.WriteLine("Вы ввели не трехзначное число, пожалуйста повторите ввод");
    return;                                          // возврат if еще не показывали
}

Console.WriteLine($"Введенное число '{number}' "); // Эту строку можно было убрать, т.к. в терминале и так видно какое число введено.
int secondRank = number / 10 % 10;                 // Эту переменную можно было не вводить, а вписать формулу в Console.WriteLine
Console.WriteLine($"Вторая цифра '{secondRank}' ");
