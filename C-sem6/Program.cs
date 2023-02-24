// -----------ГЕНЕРАЦИЯ РАНДОМНЫХ ВЕЩЕСТВЕННЫХ ЧИСЕЛ В МАССИВЕ---------
// с учетом того, что числа больше 1

// double[] GenerateArray(int size, int minValue, int maxValue)
// {
//     double[] arr = new double[size];
//     var rand = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {

//         arr[i] = Math.Round(rand.NextDouble() * (maxValue - minValue) + minValue, 4); //вариант записи1
//         // arr[i] = Math.Round(rand.Next(minValue, maxValue) + rand.NextDouble(), 3); //варианn записи2
//     }
//     return arr;
// }
// void PrintArray(double[] array) //в принте тоже меняетм int на double
// {
//     System.Console.WriteLine("[" + string.Join(", ", array) + "]");
// }

// double[] Marr = GenerateArray(7, 1, 10); // int меняем на double
// PrintArray(Marr);

//----------------МЕТОД РАЗВОРОТА МАССИВА------
// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент 
// будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


// int[] GenerateArray(int size, int minValue, int maxValue)
// {
//     int[] arr = new int[size];
//     Random rand = new Random();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rand.Next(minValue, maxValue + 1); //+1 чтобы захватить правую границу
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
// }

// // void ReverseArray(int[] arr) 
// // {
// //     int temp; //можно не задавать размер переменной
// //     for (int i = 0; i < arr.Length / 2; i++)
// //     {
// //         temp = arr[i];
// //         arr[i] = arr[arr.Length - 1 - i];
// //         arr[arr.Length - 1 - i] = temp;
// //     }
// // }

// //вместо  функции выше можно использовать готовую функцию, которую записать в конце
// // Array.Reverse();

// var Marr = GenerateArray(5, 0, 10);
// PrintArray(Marr);
// // ReverseArray(array); //при использовании Array.Reverse(); эту строку убираем
// Array.Reverse(Marr);
// PrintArray(Marr);

// -------------------------НОВОЕ ЗАЦИКЛИВАНИЕ МЕТКА+ПЕРЕВОД СТРОКИ В МАССИВ------------------
// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли 
// существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// metka:  //любое слово и : будет снова запускать программу+необходимо в цикле поставить метку
// System.Console.WriteLine("Введите числа: ");
// int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);  //Введенную строку переводит в массив
// //строка 75 - НОВОЕ!!! Что делает: Консоль считывает строку, Сплит разделяет (разделение идет через пробел по умолчанию)
// //можно задать СПЛИТ через запятую -Split(",")- 
// // int.Parse означает преобразование в числа (можно и в текст другой опцией)
// // в ИТОГЕ получаем числа введенные с терминала преобразуются в числа в объявленном массиве

// if (array.Length != 3) // != означает точное равенство
// {
//     System.Console.WriteLine("Массив введён некоректно ");
//     goto metka; //зацикливание программы и приглашение снова к вводу
// }

// if ((array[0] + array[1]) > array[2] && (array[1] + array[2]) > array[0] && (array[0] + array[2] > array[1]))
// {
//     System.Console.WriteLine("Такой треугольник существует ");
// }
// else
// {
//     System.Console.WriteLine("Такой треугольник не существует ");
// }

// ---------------ЗАДАЧА - ПЕРЕВОД ЧИСЛА В ДВОИЧНУЮ СИСТЕМУ----------------
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 44 -> 101100
// 3  -> 11
// 2  -> 10
// -------------Решение задачи - Вариант1-----
// System.Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// string st = "";
// while (n != 0)
// {
//     st += n % 2;
//     n = n / 2;
// }
// for (int i = st.Length - 1; i >= 0; i--)
// {
//     System.Console.Write(st[i]);
// }
// System.Console.WriteLine();

// -----------Решение задачи - Вариант2 -------- РЕКУРСИЯ (NEW!!!!!!!!!!)-------
// void GetBinatyView(int number)
// {
// if (number <= 0) return;
// GetBinatyView(number / 2);
// System.Console.Write(number % 2);
// }

// System.Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// GetBinatyView(N);

// ------------------Решение задачи - Вариант3----------
// System.Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Convert.ToString(N, 2));

// ----------------ЗАДАЧА-------------
// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа 
// Фибоначчи: 0 и 1.
// Если N = 7 -> 0 1 1 2 3 5 8

// System.Console.WriteLine("Введите число n: ");
// int Fibonachi1 = 0;
// int Fibonachi2 = 1;
// int n = Convert.ToInt32(System.Console.ReadLine());
// System.Console.Write("0 1 ");
// for (int i = 0; i < n - 2; i++)
// {
//     int sum = Fibonachi1 + Fibonachi2;
//     System.Console.Write(sum + " ");
//     Fibonachi1 = Fibonachi2;
//     Fibonachi2 = sum;
// }

// ------------ЗАДАЧА-------------------
//  Задача 45: Напишите программу, которая будет создавать копию
//   заданного массива с помощью поэлементного копирования.

// ------------------Вариант1------------
// int[] GenerateArray(int size, int leftRange, int rightRange)
// {
//     int[] array = new int[size];
//     var rand = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(leftRange, rightRange + 1);
//     }
//     return array;
// }

// int[] CopyPaste(int[] array)
// {
//     int[] array2 = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array2[i] = array[i];
//     }
//     return array2;

// }
// void PrintArray(int[] array)
// {
//     System.Console.WriteLine("[" + string.Join(", ", array) + "]");
// }
// int[] arr = GenerateArray(5, 0, 50);
// PrintArray(arr);
// int[] arrCopy = CopyPaste(arr);
// PrintArray(arrCopy);

// ----------------Вариант-2-------------
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
void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}
int[] arr = GenerateArray(5, 0, 50);
int[] arrCopy = arr[..]; //-----------НОВОЕ!КОПИРОВАНИЕ МАССИВА одной строкой!!!!!!!!!НОВОЕ!!!

arr[0] = 278;//Это для проверки независимости массивов!!!!

PrintArray(arr);
PrintArray(arrCopy);
