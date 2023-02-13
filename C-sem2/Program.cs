// Напишите программу, которая выводит случайное число из отрезка
// [10, 99] и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// Random rand = new Random(); //задаем класс рандомных чисел
// int numberA = rand.Next(10, 100); //крайнее правое значение не включается, поэтому делаем +1
// Console.WriteLine($"Случайное число: {numberA}");
// int leftnumberA = numberA/10; //можно записать без переменных использовать number/10 и number%10
// int rightnumberA = numberA%10;
// //System.Console.WriteLine($"{leftnumberA} {rightnumberA}"); // это для проверки
// if (leftnumberA > rightnumberA)
// {
//     System.Console.WriteLine($"Левое число больше правого и равно: {leftnumberA}");
// }
// else if (leftnumberA < rightnumberA)
// {
//     System.Console.WriteLine($"Правое число больше левого и равно: {rightnumberA}");
// }
// else
// {
//     System.Console.WriteLine($"Правое число равно левому");
// }
//---------end------------

// Напишите программу, которая выводит случайное трехзначное число 
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// Random rand = new Random(); //задаем класс рандомных чисел
// int number = rand.Next(100, 1000); //крайнее правое значение не включается, поэтому делаем +1
// Console.WriteLine($"Случайное число: {number}");
// // int leftnumberA = number / 100;
// // int rightnumberA = number % 10;
// // System.Console.WriteLine($"{number / 100}{number % 10}");
//  number = ((number / 100)*10 + number % 10);
//  System.Console.WriteLine(number);
//--------end-------

// Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// System.Console.WriteLine("Enter number 1: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter number 2: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number1 % number2 == 0)
// {
//     System.Console.WriteLine($"Число 2 кратно числу 1 и равно {number1 / number2}");
// }
// else
// {
//     System.Console.WriteLine("Число 2 не кратно числу 1, остаток от деления = " + number1 % number2);
// }
// -------------------end--------------------------

// Напишите программу, которая принимает на вход число и проверяет,
//  кратно ли оно одновременно 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

// System.Console.WriteLine("Enter number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a % 7 == 0 && a % 23 == 0)
// {
//     System.Console.WriteLine("Число кратно 7 и 23");
// }
// else
// {
//     System.Console.WriteLine("Число не кратно 7 и 23");
// }
// -----------------End-------------------

// Напишите программу, которая принимает на вход два числа и
//  проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

System.Console.Write("Enter number1: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter number2: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a*a == b)
{
   System.Console.WriteLine($"Число {a} является квадратом числа {b}"); 
}
if (b*b == a)
    {
        System.Console.WriteLine($"Число {b} является квадратом числа {a}");
    }
    else
    {
        System.Console.WriteLine("Числа не являются квадратом друг друга");
    }