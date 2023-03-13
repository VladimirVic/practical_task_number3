// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите размер массива : ");
int size = Convert.ToInt32(Console.ReadLine());


int[] GetArray(int Size, int minValue, int maxValue)
{
  int[] res = new int[Size];
  for (int i = 0; i < res.Length; i++)
  {
    res[i] = new Random().Next(minValue, maxValue + 1);
  }
  return res;
}
void PrintArray(int[] inarray)
{
  for (int i = 0; i < inarray.Length; i++)
  {
    Console.WriteLine(inarray[i]);
  }
}
int[] arr = GetArray(size, 1, 9);
PrintArray(arr);

int Diff(int[] Xarray)   //создаём метод поска max min и разнице их в массиве
{
  int max = Xarray[0];
  int min = Xarray[0];
  int dif = 0;
  for (int i = 0; i < Xarray.Length; i++)
  {
    if (Xarray[i] > max)
    {
      max = Xarray[i];
    }
    if (Xarray[i] < min)
    {
      min = Xarray[i];
    }
    dif = max - min;
  }
  return dif;
}
int N = Diff(arr);
Console.WriteLine($"разница max - min = {N} ");




