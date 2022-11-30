//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//Не использовать string[]
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.Clear();

Console.WriteLine("Введите любое целое число");

bool isParsed = int.TryParse(Console.ReadLine(), out int fullNumber);
if (!isParsed)
{
    Console.WriteLine("Введите корректные данные");
    return;
}

int number = fullNumber;

if (number < 0)
{
    number = -number;
}

if (number < 100)
{
    Console.WriteLine($"{fullNumber} -> третьей цифры нет");
}
else
{
    while (number > 1000)
    {
        number = number/10;
    }

    int result = number % 10;

    Console.WriteLine($"Третья цифра числа {fullNumber} -> {result}");
}