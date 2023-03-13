// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// int[,] matrix = new int [3,4]; //Запись 2х мерного массива, если надо 3х- мерный, то int[,,]  и тд.

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());

// }

// int[,] GenereteMatrix(int rows, int cols)
// {
//     Random rand = new Random();
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(0, 11);
//         }
//     }
//     return matrix;
// }

// // int[,] test = new int [3,4];
// // System.Console.WriteLine(test.GetLenght(0)); // НОВОЕ!!!! если нужно вывести, узнать длину двумерного 
// // массива, то use Get.Lenght(0); - Где 0 означает СТРОКИ, а 1 - СТОЛБЦЫ.

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t"); // \t - Это ТАБУЛЯЦИЯ для красивого вывода
//         }
//         System.Console.WriteLine(); // вывод пустой строки, чтобы было красиво
//     }
// }

// int rows = ReadInt("Введите количество строк: ");
// int cols = ReadInt("Введите кличество столбцов: ");
// System.Console.WriteLine(); //пустая строка для красивого вывода
// var MyMatrix = GenereteMatrix(rows, cols);
// PrintMatrix(MyMatrix);


// -----------------ЗАДАЧА--------------
// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
// по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// rows = 3, cols = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());

// }

// int[,] AddMatrix(int rows, int cols)
// {
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = i + j;
//         }
//     }
//     return matrix;
// }


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t"); // \t - Это ТАБУЛЯЦИЯ для красивого вывода
//         }
//         System.Console.WriteLine(); // вывод пустой строки, чтобы было красиво
//     }
// }
// int rows = ReadInt("Введите количество строк: ");
// int cols = ReadInt("Введите кличество столбцов: ");
// System.Console.WriteLine(); //пустая строка для красивого вывода
// var MyMatrix = AddMatrix(rows, cols);
// PrintMatrix(MyMatrix);


// --------------------------ЗАДАЧА-----------------------------------
// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените 
// эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());

// }

// int[,] GenereteMatrix(int rows, int cols)
// {
//     Random rand = new Random();
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(0, 11);
//         }
//     }
//     return matrix;
// }

// void AddMatrix(int[,] matrix2)
// {
//     for (int i = 1; i < matrix2.GetLength(0); i += 2)
//     {
//         for (int j = 1; j < matrix2.GetLength(1); j += 2)
//         {

//             matrix2[i, j] = matrix2[i, j] * matrix2[i, j];
//         }

//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t"); // \t - Это ТАБУЛЯЦИЯ для красивого вывода
//         }
//         System.Console.WriteLine(); // вывод пустой строки, чтобы было красиво
//     }
// }
// int rows = ReadInt("Введите количество строк: ");
// int cols = ReadInt("Введите кличество столбцов: ");

// var MyMatrix1 = GenereteMatrix(rows, cols);
// PrintMatrix(MyMatrix1);
// System.Console.WriteLine(); //пустая строка для красивого вывода
// AddMatrix(MyMatrix1);
// PrintMatrix(MyMatrix1);

// -----------------ЗАДАЧА--------------------------
// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
//  (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// ---------------------ВАРИАНТ РЕШЕНИЯ 1------------------
// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GenereteMatrix(int rows, int cols)
// {
//     Random rand = new Random();
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(0, 11);
//         }
//     }
//     return matrix;
// }

// // int SumMatrix(int[,] matrix2)
// // {
// //     int sum = 0;
// //     for (int i = 0; i < matrix2.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < matrix2.GetLength(1); j++)
// //         {
// //             if (i == j)
// //             {
// //                 sum = sum + matrix2[i, j];
// //             }
// //         }

// //     }
// //     return sum;
// // }

// // -----------ВАРИАНТ 2 (только по этой функции) ---ТЕРНАРНЫЙ ОПЕРАТОР - НОВОЕ!!!!!!!!-----------

// int SumMatrix(int[,] matrix2)
// {
//     int sum = 0;
//     int length = matrix2.GetLength(0) > matrix2.GetLength(1) ? matrix2.GetLength(1) : matrix2.GetLength(0);
//     //DВместо всех FOR указываем условие, потом занк ? если TRUE через : False
//     for (int i = 0; i < length; i++)
//     {
//         sum += matrix2[i, i];
//     }
//     return sum;
// }


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t"); // \t - Это ТАБУЛЯЦИЯ для красивого вывода
//         }
//         System.Console.WriteLine(); // вывод пустой строки, чтобы было красиво
//     }
// }
// int rows = ReadInt("Введите количество строк: ");
// int cols = ReadInt("Введите кличество столбцов: ");
// var MyMatrix1 = GenereteMatrix(rows, cols);
// PrintMatrix(MyMatrix1);
// System.Console.WriteLine(SumMatrix(MyMatrix1)); //пустая строка для красивого вывода


