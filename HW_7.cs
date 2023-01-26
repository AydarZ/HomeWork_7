// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// int GetSizeArray (string message)
// {
//     System.Console.WriteLine("Введите размер " + message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void FillArray(int[,] array)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(-9, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(string.Format("{0,5}", array[i, j] + " "));
//         }
//         System.Console.WriteLine();
//     }
// }

// int m = GetSizeArray("m");
// int n = GetSizeArray("n");
// int[,] Array = new int[m, n];
// FillArray(Array);
// PrintArray(Array);






// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int GetNumber(string message)
// {
//     System.Console.WriteLine("Введите " + message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void FillArray(int[,] array)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(-9, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(string.Format("{0,5}", array[i, j] + " "));
//         }
//         System.Console.WriteLine();
//     }
// }

// void FindElementOfArray(int[,] array)
// {
//     int m = GetNumber("индекс строки элемента");
//     int n = GetNumber("индекс столбца элемента");
//     if (m < array.GetLength(0) && n < array.GetLength(1))
//     {
//         int result = array[m, n];
//         System.Console.WriteLine("Найденный элемент имеет значение " + result);
//     }
//     else
//     {
//         System.Console.WriteLine("такого элемента нет");
//     }

// }

// int[,] Array = new int[5, 5];
// FillArray(Array);
// PrintArray(Array);
// FindElementOfArray(Array);





// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// void FillArray(int[,] array)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(string.Format("{0,5}", array[i, j] + " "));
//         }
//         System.Console.WriteLine();
//     }
// }

// string FindAverage(int[,] array)
// {
//     double avg;
//     string Average = string.Empty;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double summ = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             int element = array[i, j];
//             summ += element;
//         }
//         avg = summ / array.GetLength(0);
//         Average += $"{avg}" + "; ";
//     }
//     return Average;
// }


// int[,] Array = new int[5, 5];
// FillArray(Array);
// PrintArray(Array);
// System.Console.WriteLine("Среднее арифметическое каждого столбца: " + FindAverage(Array));