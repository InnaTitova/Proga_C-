// -----Разбор дз про паралидром-----
// int convertedNum = Convert.ToInt32(Convert.ToString(num[2])); -конвертация из текста в цифру
// Артём Макеев: string? num = Console.ReadLine(); ? -убираем предупреждение о том, что строка м.б. пустой
// Артём Макеев: if(num!.Length == 5) - !-означает, что предупрежден о том, что сторока м.б. пустой (просто скрытие ошибок при исполнении кода)
// ВАрианты решений Артём Макеев: 
// System.Console.Write("Введите число: ");
// string? num = Console.ReadLine();
// if(num[0] == num[4] && num[1] == num[3])
// {
// System.Console.WriteLine("Число является палиндромом");
// }
// else
// {
// System.Console.WriteLine("Число не является палиндромом");
// }
// -----вариант математический-----
// Артём Макеев: 
// System.Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num / 10000 == num % 10 && num / 1000 % 10 == num % 10000 / 1000)
// {
// System.Console.WriteLine("Число является палиндромом");
// }
// else
// {
// System.Console.WriteLine("Число не является палиндромом");
// }

// -------ЗАДАЧИ------------
// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму 
// чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// System.Console.Write("Enter number A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int result = 0;
// for (int i = 1; i <= A; i++)
// {
//    result += i;  // result = result + i
// }
//  System.Console.Write($"Сумма чисел от числа {A} равна {result}"); 

// -----Решение через функцию-----

// int GetNumber(string text)
// {
//     System.Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int SumGets(int num)
// {
//     int result = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         result += i;
//     }
//     return result;
// }
// int A = GetNumber("Введите число А: ");
// System.Console.Write($"Сумма чисел от числа {A} равна {SumGets(A)}"); 
// Можно вывести так 
// int res = GetSumElements(num);
// System.Console.WriteLine($"Сумма чисел от 1 до {num} = {res}");
//----------------end--------------

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество 
// цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.Write("Enter number: ");
// // int a = Convert.ToInt32(Console.ReadLine());
// // string aText = Convert.ToString(a);
// // System.Console.WriteLine($"Количество цифр в числе: {aText.Length}");
// string? a = Console.ReadLine();
// System.Console.WriteLine($"Количество цифр в числе: {a.Length}");
// //-------------End--------------------

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт
//  произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// int GetNumber(string text)
// {
//     System.Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int n = GetNumber("Введите число: ");
// int Multinum(int x)
// {
//     int result = 1;
//     for (int i = 1; i <= x; i++)
//     {
//         result = result * i;
//     }
//     return result;
// }
// System.Console.Write($"Факториал от числа {n} равен {Multinum(n)}");
// ---------------Задача сверху не работает-----------

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный
//  нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] FillArray(int size)
// {
//     int[] arr1 = new int [size];
//     int length = arr1.Length;
//     for (int i=0; i < length; i++)

//     {
//         arr1[i] = new Random().Next(0, 2);

//     }
//     return arr1;
// }
// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         System.Console.Write($"{col[position]}, ");
//         position++;
//     }
// }
// int[] array1 = FillArray(25);
// PrintArray(array1);
//------Вариант решения-1---
// int[] GetArray()
// {
//     var arr = new int[8];
//     var rand = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rand.Next(0, 2);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
// }

// var myArray = GetArray();
// PrintArray(myArray);


// -----Вариант решения -2-----------
void GetArray(int[] arr)
{
    var rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 2);
    }
}

void PrintArray(int[] arr)
{
    // System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
    //данная строка заменяет следующее:
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}

int[] myArray = new int[23];
GetArray(myArray);
PrintArray(myArray);