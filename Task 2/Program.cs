/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Write("Введите целое трехзначное число: ");
int user_number = Convert.ToInt32(Console.ReadLine());

void third_number(int user_number)
{
    if (user_number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }

    else if (user_number > 99)
    {
        while (user_number > 999)
        {
            user_number = user_number / 10;
        }
            Console.Write("Третья цифра числа = " + user_number % 10);
    }

    else
{
    Console.WriteLine("Третья цифра числа " + user_number + " = " + user_number % 10);
}
}

third_number(user_number);