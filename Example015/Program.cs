// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
Console.WriteLine("Введите порядковый номер дня недели: ");
int numberWeek = Convert.ToInt32(Console.ReadLine());
if (numberWeek > 0 && numberWeek < 8)
{
    if (numberWeek < 6)
    {
        Console.WriteLine(numberWeek);
        Console.WriteLine("Указанный день не является выходным.");
    }
    else
    {
        Console.WriteLine(numberWeek);
        Console.WriteLine("Указанный день является выходным.");
    }
}
else
{
    Console.WriteLine("Неверный порядковый номер дня. В неделе всего 7 дней !!!");
}