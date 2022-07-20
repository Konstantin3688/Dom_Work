/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

while (true)
{
    Console.WriteLine("Введите пятизначное число...");
    int number = int.Parse(Console.ReadLine());
    if (number < 99999 && number > 10000)
    {
        if (number % 10 == number / 10000 % 10 
        && number / 10 % 10 == number / 1000 % 10)
        {
            Console.WriteLine(" число ЯВЛЯЕТСЯ палиндромом");
        }
        else
        {
            Console.WriteLine(" число НЕ ЯВЛЯЕТСЯ палиндромом");
        }
        break;
    }
    else
        Console.WriteLine("Вы ввели не верное число!");
}