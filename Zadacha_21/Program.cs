/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Write("Enter x ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Enter y ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Enter z ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Enter x2 ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Enter y2 ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Enter z2 ");
int z2 = int.Parse(Console.ReadLine());
Console.WriteLine("Длина отрезка равна... " + GetLength(x1, y1, z1, x2, y2, z2));
double GetLength(int x, int y, int z, int x2, int y2, int z2)
{
    double Distance = Math.Sqrt
    (
        (x2 - x) * (x2 - x) + (y2 - y) * (y2 - y) + (z2 - z) * (z2 - z)
    );

    return Distance;
}