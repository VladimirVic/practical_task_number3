//  ВВодим три числа в консоль и они сохраняются в массиве
// Console.Write("Введите три числа");
// int[] arr = new int[3]; 
// for(int i=0; i < arr.Length; i++)
// {
//   arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// тут выводим на консоль числа из массива
// int[] arr = {5, 8, 3}; // сами задали массив из чисел
// for(int i = 0; i < arr.Length; i++)
// {
//   Console.WriteLine(arr[i]); //вывели числа на консоль
// }


// !!!  Делаем рандомный массив и потом выводим его цифры в консоль
// int[] arr = new int[5];                    // создали 5 нулей
// for (int i = 0; i < arr.Length; i++)
// {
//   arr[i] = new Random().Next(0, 2);        // создали рандомные числа от 0 до 1
// }
// // выводим рандом. массив на консоль
// for(int i = 0; i < arr.Length; i++)
// {
//   Console.Write(arr[i]);                   // так цифры выводятся в линию а не в столб в консоле
// }

// !!!!теперь тоже самое но создаём функции для создания рандомного массива и функцию вывода на консоль массива

// void FillArray(int[] Collection) //создали невозвр. функция с названием FillArray положили в неё аргумент (наш массив) который создадим 
// {
//   for (int i = 0; i < Collection.Length; i++)
//   {
//     Collection[i] = new Random().Next(0, 2);        // создали рандомные числа от 0 до 1
//   }
// }

// // делаем метод кот. будет выводить массив на консоль
// void ArrayPrint(int[] col)   //создали метод с аргументом 
// {
//   int count = col.Length;
//   int posicion = 0;
//   while (posicion < count)
//   {
//     Console.Write(col[posicion]);
//     posicion++;
//   }
// }

// int[] array = new int[5];          // создали массив из чисел целых с названием arrау и положили в него 5 нулей

// FillArray(array);                   // так мы вызываем метод
// ArrayPrint(array);                  // так мы вызываем метод
