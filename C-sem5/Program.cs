// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//  Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

// int[] GetArr(int size, int min, int max) //Заполнение массива случайными числами с указанием длины массива, начальных и конечных значений для случайных чисел
// {
//     int[] arr = new int[size]; //создаем новый массив указанного размера
//     var rand = new Random(); //заполняем случайными числами
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rand.Next(min, max + 1); //потому что правая граница не берется, надо добавить 1
//     }
//     return arr;
// }

// void PrintArr(int[] arr) //это функция вывода массива
// {
//     System.Console.WriteLine("[" + string.Join(", ", arr) + "]"); //после запятой ПРОБЕЛ
// }

//-----все сверху одинаковое для всех!!! Ниже разничаются-----------

// --------------------------------Решение сложения -вариант1-----
// int SumNegat(int[] arr) //функция для сложения отриц чисел
// {
//     int result = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] < 0)
//         {
//             result += arr[i];
//         }
//     }
//     return result;
// }

// int SumPositiv(int[] arr) //функция для сложения положит чисел
// {
//     int result = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0)
//         {
//             result += arr[i];
//         }
//     }
//     return result;
// }
// ----------вывод массива для варианта 1----------
// int[] MyArr = GetArr(12, -9, 9); //вывод массива по условиям задачи, ЭТО вызов функции
// PrintArr(MyArr);
// System.Console.WriteLine($"Сумма отрицательных элементов = {SumNegat(MyArr)}");
// System.Console.WriteLine($"Сумма положительных элементов = {SumPositiv(MyArr)}");


//-----------------------------Вариант сложения 2--------------

// int[] SumNegatAndPositiv(int[] arr)
// {
//     int[] result = new int[2]; // 2 - потому что есть положит и отрицат числа
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] < 0)
//         {
//             result[0] += arr[i]; // 0 - ЭТО ячейка памяти отриц чисел
//         }
//         else
//         {
//             result[1] += arr[i]; // 1- это ячейка памяти положит чисел
//         }
//     }
//     return result;
// }

// // вывод массива для варианта 2
// int[] MyArr = GetArr(12, -9, 9); //вывод массива по условиям задачи, ЭТО вызов функции
// PrintArr(MyArr);
// int[] sums = SumNegatAndPositiv(MyArr);
// System.Console.WriteLine($"Сумма отрицательных элементов = {sums[0]}");
// System.Console.WriteLine($"Сумма положительных элементов = {sums[1]}");


//--------------------------Вариант сложения 3----------------Самый короткий---

// void SumNegatAndPositiv(int[] arr, out int SumNegativ, out int SumPositiv) //out int -НОВАЯ ФУНКЦИЯ
// //void не возвращает нам никакие значения, но мы можем вытаскивать переменные
// {
//    SumNegativ=0; //int не нужно, потому что выше уже присвоено int
//    SumPositiv=0;

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] < 0)
//         {
//             SumNegativ += arr[i]; 
//         }
//         else
//         {
//             SumPositiv += arr[i]; 
//         }
//     }

// }
// // вывод массива для варианта 3
// int[] MyArr = GetArr(6, -9, 9); //вывод массива по условиям задачи, ЭТО вызов функции
// PrintArr(MyArr);
// SumNegatAndPositiv(MyArr, out int SumNegativ, out int SumPositiv);
// System.Console.WriteLine($"Сумма отрицательных элементов = {SumNegativ}");
// System.Console.WriteLine($"Сумма положительных элементов = {SumPositiv}");


// // -----------------ЗАДАЧА-2-------------
// // Задача 32: Напишите программу замена элементов массива: положительные элементы замените на 
// // соответствующие отрицательные, и наоборот.
// // [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// int[] GetArr(int size, int min, int max) //Заполнение массива случайными числами с указанием длины массива, начальных и конечных значений для случайных чисел
// {
//     int[] arr = new int[size]; //создаем новый массив указанного размера
//     var rand = new Random(); //заполняем случайными числами
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rand.Next(min, max + 1); //потому что правая граница не берется, надо добавить 1
//     }
//     return arr;
// }

// void PrintArr(int[] arr) //это функция вывода массива
// {
//     System.Console.WriteLine("[" + string.Join(", ", arr) + "]"); //после запятой ПРОБЕЛ
// }
// void NumNegatAndPositiv(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = -arr[i];
//     }
// }

// int[] MyArr = GetArr(6, -9, 9); //вывод массива по условиям задачи, ЭТО вызов функции
// PrintArr(MyArr);
// NumNegatAndPositiv(MyArr);
// PrintArr(MyArr);

// ---------------------ЗАДАЧА 3---------------------
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число
//  в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

//------эта функция не использовалась здесь------
// int ImputNumber(string str1) //str1- выдуманное Это функция ВВОДА ЧИСЛА
// {
//     System.Console.WriteLine(str1);
//     return Convert.ToInt32(Console.ReadLine());
// }
// //-------------Вариант 1 решения задачи3 (ЧЕРЕЗ bool)

// int[] GetArr(int size, int min, int max) //Заполнение массива случайными числами с указанием длины массива, начальных и конечных значений для случайных чисел
// {
//     int[] arr = new int[size]; //создаем новый массив указанного размера
//     var rand = new Random(); //заполняем случайными числами
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rand.Next(min, max + 1); //потому что правая граница не берется, надо добавить 1
//     }
//     return arr;
// }

// void PrintArr(int[] arr) //это функция вывода массива
// {
//     System.Console.WriteLine("Массив [" + string.Join(", ", arr) + "]"); //после запятой ПРОБЕЛ
// }

// // bool FindNumber(int[] arr, int num1)
// bool FindNumber(int[] arr, int num2)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == num2)
//         {
//             return true;
//         }
//             }
//     return false;
// }

// System.Console.WriteLine("Введите число для проверки: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] MyArr = GetArr(20, 0, 8); //вывод массива по условиям задачи, ЭТО вызов функции
// PrintArr(MyArr);
// if (FindNumber(MyArr, number))
// {
//     System.Console.WriteLine("Да, такой элемент есть");
// }
// else
// {
//     System.Console.WriteLine("Такого элемента нет");
// }
// //--------Вариант 2 решения задачи3 (ЧЕРЕЗ void)----------

// int[] GetArr(int size, int min, int max) //Заполнение массива случайными числами с указанием длины массива, начальных и конечных значений для случайных чисел
// {
//     int[] arr = new int[size]; //создаем новый массив указанного размера
//     var rand = new Random(); //заполняем случайными числами
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rand.Next(min, max + 1); //потому что правая граница не берется, надо добавить 1
//     }
//     return arr;
// }

// void PrintArr(int[] arr) //это функция вывода массива
// {
//     System.Console.WriteLine("Массив [" + string.Join(", ", arr) + "]"); //после запятой ПРОБЕЛ
// }

// void FindNumber(int[] arr, int num2)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == num2)
//         {
//             System.Console.WriteLine("Такое число есть");
//             return;
//         }
//     }
//     System.Console.WriteLine("Такого числа нет");;
// }

// System.Console.WriteLine("Введите число для проверки: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] MyArr = GetArr(20, 0, 8); //вывод массива по условиям задачи, ЭТО вызов функции
// PrintArr(MyArr);
// FindNumber(MyArr, number);

// //----------------Вариант 3 решения задачи 3----------(ЧЕРЕЗ Array.IndexOf)
// //Array.IndexOf(MyArr, number) - функция принимает на вход массив и число, в массиве ищет цифру и 
// //выводит ее индекс, если нет числа в массиве выводит -1.

// int[] GetArr(int size, int min, int max) //Заполнение массива случайными числами с указанием длины массива, начальных и конечных значений для случайных чисел
// {
//     int[] arr = new int[size]; //создаем новый массив указанного размера
//     var rand = new Random(); //заполняем случайными числами
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rand.Next(min, max + 1); //потому что правая граница не берется, надо добавить 1
//     }
//     return arr;
// }
// void PrintArr(int[] arr) //это функция вывода массива
// {
//     System.Console.WriteLine("Массив [" + string.Join(", ", arr) + "]"); //после запятой ПРОБЕЛ
// }

// System.Console.WriteLine("Введите число для проверки: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] MyArr = GetArr(9, 1, 8); //вывод массива по условиям задачи, ЭТО вызов функции
// PrintArr(MyArr);
// System.Console.WriteLine(Array.IndexOf(MyArr, number));

//-----------------ЗАДАЧА 4---------------------
// Задача4: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] GetArr(int size, int min, int max) //Заполнение массива случайными числами с указанием длины массива, начальных и конечных значений для случайных чисел
// {
//     int[] arr = new int[size]; //создаем новый массив указанного размера
//     var rand = new Random(); //заполняем случайными числами
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rand.Next(min, max + 1); //потому что правая граница не берется, надо добавить 1
//     }
//     return arr;
// }

// void PrintArr(int[] arr) //это функция вывода массива
// {
//     System.Console.WriteLine("Массив [" + string.Join(", ", arr) + "]"); //после запятой ПРОБЕЛ
// }

// int SumNumber(int[] arr) //функция для сложения  чисел 
// {
//     int result = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] >= 10 && arr[i] <= 99)
//         {
//             result++;
//         }
//     }
//     return result;
// }
// int[] MyArr = GetArr(23, -100, 100);
// PrintArr(MyArr);
// System.Console.WriteLine($"Количество элементов от 10 до 99 = {SumNumber(MyArr)}");

//---------------------ЗАДАЧА 5----------------------
// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний
//  элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

int[] GetResult(int[] array)
{
    int size;
    if (array.Length % 2 == 0)
        size = array.Length / 2;
    else
        size = array.Length / 2 + 1;

    int[] arrResult = new int[size];

    for (int i = 0; i < size; i++)
    {
        arrResult[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 != 0)
    {
        arrResult[arrResult.Length - 1] = array[size - 1];
    }

    return arrResult;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int[] arr = GenerateArray(7, 1, 10);
PrintArray(arr);
int[] newArr = GetResult(arr);
PrintArray(newArr);

