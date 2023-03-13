// Задача 29:Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


void FillArray(int[] Collection) //создали невозвр. функция с названием FillArray положили в неё аргумент (наш массив) который создадим 
{
  for (int i = 0; i < Collection.Length; i++)
  {
  Collection[i] = new Random().Next(0, 2);        // создали рандомные числа от 0 до 1
  }
}

// делаем метод кот. будет выводить массив на консоль
void ArrayPrint(int[] col)   //создали метод с аргументом 
{
  int count = col.Length;
  int posicion = 0;
  while (posicion < count)
  {
    Console.Write(col[posicion]);
    posicion++;
  }
}

int[] array = new int[8];          // создали массив из чисел целых с названием arr и положили в него 5 нулей

FillArray(array);
ArrayPrint(array);