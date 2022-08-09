/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.Write("Введите целое трехзначное число: ");
int user_number = Convert.ToInt32(Console.ReadLine());

int second_number(int user_number)
{
   int result = user_number / 10 % 10;
   return result; 
}

int res = second_number(user_number);
Console.WriteLine(res);