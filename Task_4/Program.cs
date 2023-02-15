// Программа проверяет пятизначное число на палиндром. Рандомное заполнение массива.
int[] array = new int[5];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(10);
    Console.Write(array[i]);
}
if (array[0] == array[4] && array[1] == array[3]) Console.WriteLine(array + "- палиндром");
else Console.WriteLine(array + "- не палиндром");


// Другое решение с функцией bool
bool palindrom(int[] arr)
{
    return arr[0] == arr[4] && arr[1] == arr[3];
}

int[] array1 = new int[5];
Random rand1 = new Random();
for (int i = 0; i < array1.Length; i++)
{
    array1[i] = rand.Next(10);
    Console.Write(array1[i]);
}
Console.WriteLine(" " + palindrom(array1));