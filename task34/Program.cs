// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] array = new int[4];
// for(int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(100, 1000);
// }
// for (int i = 0; i < array.Length; i++)
// {
//   Console.WriteLine(array[i]);
// }
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//   if (array[i] % 2 == 0)
//   count++;
// }
// Console.WriteLine($"количество чётных чисел = {count} ");

Console.WriteLine("Введите размер массива");   // просим ввести длину массива
int size = Convert.ToInt32(Console.ReadLine());  // число из строки переводим в инт
int[] numbers = new int[size];        // это число будет означать длину массива с названием numbers

int[] GetArray(int[] array, int minValue, int maxValue) //создаем метод с аргументами, 1ый аргумент- массив внутри  метода 
{
  for (int i = 0; i < array.Length; i++)   // цикл для создания чисел массива
  {
    array[i] = new Random().Next(minValue, maxValue);
  }
  return array;   // возвращаем массив
}

void PrintArray(int[] inarray)  // создаём метод отображения на консоли
{
  for (int i = 0; i < inarray.Length; i++)
  {
    Console.WriteLine(inarray[i]);
  }
}
int[] arr = GetArray(numbers, 100, 1000); // создаём новый массив co значениями
PrintArray(arr);     // вызываем метод PrintArray с новой переменной

int method(int[] Xarray)   //создаём метод поска чётных чисел в массиве
{
  int count = 0;
  for (int i = 0; i < Xarray.Length; i++)
  {
    if (Xarray[i] % 2 == 0)
      count++;
  }
  return count;
}
int N = method(arr);
Console.WriteLine($"количество чётных чисел в массиве = {N} ");


