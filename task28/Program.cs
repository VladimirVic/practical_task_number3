﻿// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Mult(int A)
{
int result = 1;
for (int i = 1; i <= A; i++)
{
result = result * i;
}
return result;

}
Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел равна: {Mult(A)}");