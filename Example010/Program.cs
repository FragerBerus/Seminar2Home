// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
Console.WriteLine("Введите трехзначное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    if (number < 1000)
    {
        int twoDigits = number / 10;
        int secondDigit = twoDigits % 10;
        Console.WriteLine("Вторая цифра числа: " + secondDigit);
    }
    else
    {
        Console.WriteLine("Введенное число не является трехзначным.");
    }
}
else
{
    Console.WriteLine("Введенное число не является трехзначным.");
}
