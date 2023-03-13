// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите размер массива : ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

int[] GetArray(int[] Array)
{
  for (int i = 0; i < Array.Length; i++)
  {
    Array[i] = new Random().Next(1, 10);
  }
  return Array;
}
void PrintArray(int[] Arr)
{
  for (int i = 0; i < Arr.Length; i++)
  {
    Console.WriteLine(Arr[i]);
  }
}
int[] ARR = GetArray(numbers);  //создаём новый массив, кот принимает зачения метода с кол-вом чисел равных numbers
PrintArray(ARR);

// ищем сумму  нечетных i :
int method(int[] Xarray)   //создаём метод поска чётных чисел в массиве
{
  int sum = 0;
  for (int i = 1; i < Xarray.Length; i+=2)
  {
    
      sum = sum + Xarray[i];
  }
  return sum;
}
int N = method(ARR);
Console.WriteLine($"сумма чисел на нечётных позициях в массиве = {N} ");
