/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int[] numbers = new int[8];
Random arr = new Random();

for (int i = 0; i < 8; i++)
{
    numbers[i] = arr.Next(1, 999);
    Console.Write(numbers[i] + " ");
}

