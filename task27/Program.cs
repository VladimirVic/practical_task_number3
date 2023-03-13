// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int num = 0;
int sum = 0;
while (N > 0)
{
  num = N % 10;
  sum = sum + num;
  N = N / 10;
}
Console.WriteLine($"Сумма цифр в числе равна: {sum}" );


