/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

System.Console.Write("Введите размер массива: ");
int sizeArr = int.Parse(Console.ReadLine());

int[] GetArr(int sizeArr)
{
    Random rnd = new Random();
    int[] arr = new int[sizeArr];

    for (int i = 0; sizeArr > i; i++)
    {
        arr[i] = rnd.Next(-100, 101);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; arr.Length > i; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
    return;
}


int sum = 0;
int[] array = GetArr(sizeArr);

PrintArray(array);

for (int i = 1; sizeArr > i; i += 2)
{
    sum = array[i] + sum;
}
System.Console.Write("Сумма элементов, стоящих на нечётных позициях равна: " + sum);