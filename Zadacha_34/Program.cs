/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Console.WriteLine("Введите размер массива");
int sizeArr = int.Parse(Console.ReadLine());

int[] GetArr(int sizeArr)
{
    Random rnd = new Random();
    int[] arr = new int[sizeArr];

    for (int i = 0; sizeArr > i; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

int count = 0;

int[] array = GetArr(sizeArr);


for (int i = 0; sizeArr > i; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
    Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Количестов четных чисел: " + count);