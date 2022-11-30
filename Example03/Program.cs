//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.Clear();

Console.WriteLine("Введите число от 1 до 7");

bool isParsed = int.TryParse(Console.ReadLine(), out int number);
if (!isParsed)
{
    Console.WriteLine("Введите корректные данные");
    return;
}

int Mon = 1,
    Tues = 2,
    Wed = 3,
    Thurs = 4,
    Fri = 5,
    Sat = 6,
    Sun = 7;

if (number > 0 && number < 8)
{
    if (number == Sat | number == Sun)
    {
        Console.WriteLine("ДА");
    }
    else
    {
        Console.WriteLine("НЕТ");
    }
}
else
{
    Console.WriteLine("Введите корректные данные");
}