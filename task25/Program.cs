// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Введите число A : ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B : ");
// int B = Convert.ToInt32(Console.ReadLine());  
// int i = 1;
// int C = 1; 
// while (i <= B)
// {
//   C = C * A;
//   System.Console.WriteLine(C);
//   i++;
// }
// System.Console.WriteLine(C);

int Exponentiation(int numberA, int numberB)
{ 
  int result = 1;
  int i = 1;
  while (i <= numberB)
  {
  result = result * numberA;
  i++;
  }
  return result;
}

Console.Write("Введите число A : ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B : ");
int B = Convert.ToInt32(Console.ReadLine());  

int degreeOf = Exponentiation(A, B);
Console.WriteLine("число А в степени В равно: " + degreeOf);    