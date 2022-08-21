/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)

45(1,0,0) 53(1,0,1)
*/

int x = EnteringValues("Введите x: ");
int y = EnteringValues("Введите y: ");
int z = EnteringValues("Введите z: ");
Console.WriteLine();

int[,,] array3 = new int[x, y, z];
GetArray(array3);
PrintArray(array3);

int EnteringValues(string input)
{
    Console.Write(input);
    int output = int.Parse(Console.ReadLine());
    return output;
}

void PrintArray(int[,,] array3)
{
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            Console.Write($"x({i}),y({j}),");
            for (int k = 0; k < array3.GetLength(2); k++)
            {
                Console.Write($"z({k}) = {array3[i, j, k]}; ");
            }
            Console.WriteLine();
        }
    }
}

void GetArray(int[,,] array3)
{
    int[] temp = new int[array3.GetLength(0) * array3.GetLength(1) * array3.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }

    int count = 0;
    for (int x = 0; x < array3.GetLength(0); x++)
    {
        for (int y = 0; y < array3.GetLength(1); y++)
        {
            for (int z = 0; z < array3.GetLength(2); z++)
            {
                array3[x, y, z] = temp[count];
                count++;
            }
        }
    }
}
