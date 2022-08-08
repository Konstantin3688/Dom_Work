/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.Write("Введите размер массива: ");
int sizeArr = int.Parse(Console.ReadLine());

double[] GetArr(int sizeArr)
{
    double[] arr = new double[sizeArr];
    Random rnd = new Random();

    for (int i = 0; sizeArr > i; i++)
    {
        arr[i] = rnd.NextDouble();
    }
    return arr;
}

void PrintArr(double[] arr)
{
    for (int i = 0; arr.Length > i; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
    return;
}

double[] arr = GetArr(sizeArr);

PrintArr(arr);

double min = arr[0];
double max = arr[0];

for (int i = 1; arr.Length > i; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }

    if (arr[i] < min)
    {
        min = arr[i];
    }
}
double diff = max - min;

Console.WriteLine("max значение массива: "+ max);
Console.WriteLine("min значение массива: " + min);
Console.WriteLine("Разница max и min элемента массива составляет: " + diff);