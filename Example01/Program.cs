//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
Console.Clear();

bool isParsed = int.TryParse(Console.ReadLine(), out int number);
if (!isParsed)
{
    Console.WriteLine("Введите корректные данные");
    return;
}

if (number < 0)
{
    number = -number;
}

if (number > 99 & number < 1000)
{
    int firstNumber = number / 100;
    int result1 = number / 10;
    int result2 = result1 - firstNumber*10;
    Console.WriteLine($"Вторая цирфа числа {number} -> {result2}");
}
else
{
    Console.WriteLine("Введите корректные данные");
}