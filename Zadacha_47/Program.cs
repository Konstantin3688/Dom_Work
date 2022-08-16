/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/


Console.WriteLine("Введите кол-во строк");
int stroki = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int stolb = int.Parse(Console.ReadLine());



double[,] GetArr(int stroki, int stolb)
{
    double[,] arr = new double[stroki, stolb];
    Random rnd = new Random();

    for (int i = 0; arr.GetLength(0) > i; i++)
    {
        for (int j = 0; arr.GetLength(1) > j; j++)
        {
            arr[i, j] = (rnd.NextDouble() - 0.5) * 100;
        }

    }
    return arr;
}
void RandomMassiv(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(string.Format("{0:F2}", array[i, j]) + "\t");
        }
        Console.WriteLine();
    }
}


double[,] massivRndChisel = GetArr(stroki, stolb);
RandomMassiv(massivRndChisel);


