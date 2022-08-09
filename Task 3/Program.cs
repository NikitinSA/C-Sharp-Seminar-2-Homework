/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.Write("Введите число, обозначающее день недели: ");
int day_number = Convert.ToInt32(Console.ReadLine());

int digit_day_number(int day_number) //показывает день недели  равный введенному числу
{
    int result = day_number;

    if (day_number == 1)
    {
        Console.Write("Понедельник");
    }

    else if (day_number == 2)
    {
        Console.Write("Вторник");
    }

    else if (day_number == 3)
    {
        Console.Write("Среда");
    }

    else if (day_number == 4)
    {
        Console.Write("Четверг");
    }

    else if (day_number == 5)
    {
        Console.Write("Пятница");
    }

    else if (day_number == 6)
    {
        Console.Write("Суббота");
    }

    else if (day_number == 7)
    {
        Console.Write("Воскресенье");
    }
    else if (day_number < 1 || day_number > 7)
    {
        Console.Write("Ошибка! Нет такого числа дня недели.");
    }
    
    return result;
}

int day_off_of_the_week(int day_number) //показывает выходной день или будний
{
    int result = day_number;
    if (day_number == 6 || day_number == 7)
    {
        Console.WriteLine(" выходной день :)");
    }
    else if (day_number < 1 || day_number > 7)
    {
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine(" будний день :(");
    }
    return result;
}

int day = digit_day_number(day_number);
int weekend = day_off_of_the_week(day_number);
