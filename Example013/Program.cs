// Задача 13:
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Например:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите число от -2147483648 до 2147483647: ");
string number = Console.ReadLine();
// int size = number.ligth; // Определяет длину строковой
                            // переменной (количество символов). 
int numberDigital = Convert.ToInt32(number);
if (numberDigital < 100 && numberDigital > (-100))
{
    Console.WriteLine("Третья цифра во введенном числе отсуствует.");
}
else
{
    if (numberDigital > 0)
    {
        Console.WriteLine("Третья цифра во введенном числе: " + number[2]);
    }    
    else
    {
        Console.WriteLine("Третья цифра во введенном числе: " + number[3]);
    }
}   
