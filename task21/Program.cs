// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53  
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2


Console.Write("Введите координаты Х1 : ");
int X1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты Y1 : ");
int Y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты Z1 : ");
int Z1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты Х2 : ");
int X2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты Y2 : ");
int Y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты Z2 : ");
int Z2 = int.Parse(Console.ReadLine()!);


int a = (X2 - X1) * (X2 - X1);
int b = (Y2 - Y1) * (Y2 - Y1);
int c = (Z2 - Z1) * (Z2 - Z1);
double abc= Math.Sqrt(a + b + c);
System.Console.WriteLine(abc);

