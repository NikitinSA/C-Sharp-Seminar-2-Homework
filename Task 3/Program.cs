/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.Write("Введите число, обозначающее день недели: ");
int day_number = Convert.ToInt32(Console.ReadLine());

void day_off_of_the_week(int day_number)
{
    if (day_number == 1)
    {
        Console.Write("Понедельник - будний день :(");
    }

    else if (day_number == 2)
    {
        Console.Write("Вторник - будний день :(");
    }

    else if (day_number == 3)
    {
        Console.Write("Среда - будний день :(");
    }

    else if (day_number == 4)
    {
        Console.Write("Четверг - будний день :(");
    }

    else if (day_number == 5)
    {
        Console.Write("Пятница - будний день :(");
    }

    else if (day_number == 6)
    {
        Console.Write("Суббота - выходной день :)");
    }

    else if (day_number == 7)
    {
        Console.Write("Воскресенье - выходной день :)");
    }
    else if (day_number < 1 || day_number > 7)
    {
        Console.Write("Ошибка! Нет такого числа дня недели.");
    }
}

day_off_of_the_week(day_number);
