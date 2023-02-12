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
// int leftnumberA = number / 100;
// int rightnumberA = number % 10;
// System.Console.WriteLine($"{number / 100}{number % 10}");
//System.Console.WriteLine(rightnumberA);
//--------end-------

// Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

