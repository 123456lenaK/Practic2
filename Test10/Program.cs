// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int number = ReadInt("Введите трехзначное число: ");
if (number < 100 || number >=1000)
{
    Console.WriteLine("Вы ввели не трехзначное число");
    return;
}
Console.WriteLine($"Число `{number}`");
int result = ((number / 10) % 10);
Console.WriteLine($"Вторая цифра `{result}`");
