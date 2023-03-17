// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GenerateMatrix(int rows, int cols)
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

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// void Zamena(int[,] matr)
// {
//     int temp;
//     for (int i = 0; i < matr.GetLength(1); i++)
//     {
//         temp = matr[0, i];
//         matr[0, i] = matr[matr.GetLength(0) - 1, i];
//         matr[matr.GetLength(0) - 1, i] = temp;
//     }
// }

// int rows = ReadInt("Введите количество строк: ");
// int cols = ReadInt("Введите кличество столбцов: ");
// var MyMatrix = GenerateMatrix(rows, cols);
// PrintMatrix(MyMatrix);
// System.Console.WriteLine(); //пустая строка для красивого вывода
// Zamena(MyMatrix);
// PrintMatrix(MyMatrix);


// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GenerateMatrix(int rows, int cols)
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

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] Zamena(int[,] matr)
// {
//     int[,] vertical = new int[matr.GetLength(1), matr.GetLength(0)];
//     for (int i = 0; i < matr.GetLength(1); i++)
//     {
//         for (int j = 0; j < matr.GetLength(0); j++)
//         {
//             vertical[i, j] = matr[j, i];
//         }
//     }
//     return vertical;
// }

// int rows = ReadInt("Введите количество строк: ");
// int cols = ReadInt("Введите кличество столбцов: ");
// var MyMatrix = GenerateMatrix(rows, cols);
// PrintMatrix(MyMatrix);
// System.Console.WriteLine(); //пустая строка для красивого вывода
// PrintMatrix(Zamena(MyMatrix));

// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь
//  содержит информацию о том, сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GenerateMatrix(int rows, int cols)
// {
//     Random rand = new Random();
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(0, 10);
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
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// --------------ВАРИАНТ РЕШЕНИЯ 1----------------
// void Chastota(int[,] matrix)
// {
//     for (int l = 0; l < 10; l++)
//     {
//         int count = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 if (l == matrix[i, j]) count++;
//             }
//         }
//         if (count > 0)
//         {
//             System.Console.WriteLine($"{l} встречается {count} раз");
//         }
//     }
// }

// ----------------ВАРИАНТ РЕШЕНИЯ 2------------------
// int[] Chastota(int[,] matrix)
// {
//     var count = new int[10];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             count[matrix[i, j]]++;
//         }


//     }
//     return count;
// }

// void PrintData(int[] arr)
// {
//     for (int i = 0; i < 10; i++)
//     {
//         if (arr[i] != 0)
//         {
//             System.Console.WriteLine($"{i} встречается {arr[i]} раз");
//         }
//     }
// }

// int rows = ReadInt("Введите количество строк: ");
// int cols = ReadInt("Введите кличество столбцов: ");
// var MyMatrix = GenerateMatrix(rows, cols);
// PrintMatrix(MyMatrix);
// System.Console.WriteLine(); //пустая строка для красивого вывода
// PrintData(Chastota(MyMatrix));

// -------------------------------------------ЗАДАЧА------------
// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку 
// и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Получаем
// 923
// 242
// 267

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void Minimum(int[,] matrix, out int minI, out int minJ)
{
    minI = 0;
    minJ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[minI, minJ] > matrix[i, j])
            {
                minI = i;
                minJ = j;
            }
        }
    }
}

int[,] Newmatrix(int[,] matrix, int minI, int minJ)
{
    int[,] newMatr = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int k = 0;
    int l = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != minI)
        {
            l = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != minJ)
                {
                    newMatr[k, l] = matrix[i, j];
                    l++;
                }
            }
            k++;
        }
    }
    return newMatr;
}


int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите кличество столбцов: ");
var MyMatrix = GenerateMatrix(rows, cols);
PrintMatrix(MyMatrix);
System.Console.WriteLine(); //пустая строка для красивого вывода
Minimum(MyMatrix, out int minI, out int minJ);
PrintMatrix(Newmatrix(MyMatrix, minI, minJ));

