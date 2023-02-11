// // Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
// // на само себя).

// // Например:
// // 4 -> 16 
// // -3 -> 9 
// // -7 -> 49
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = number * number;
// System.Console.WriteLine("Квадрат числа = " + result);
// System.Console.WriteLine($"Квадрат числа = {result} текст"); //вывод через форматированную сроку


// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

// Console.Write("Введите число 1: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a == b * b)
// {
//     Console.Write("Да,число a есть квадратный корень b");
// }
// else
// {
//     Console.Write("НЕТ,число b не есть квадратный корень a");
// }

// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

// Console.Write("Введите число от 1 до 7: ");
// int result = Convert.ToInt32(Console.ReadLine());
// if (result == 1)
// {
//     System.Console.WriteLine("Понедельник");
// }
// else if (result == 2)
// {
//     System.Console.WriteLine("Вторник");
// }
// else if (result == 3)
// {
//     System.Console.WriteLine("Среда");
// }
// else if (result == 4)
// {
//     System.Console.WriteLine("Chetverg");
// }
// else
// {
//     System.Console.WriteLine("Нет такого дня недели!");
// }
// Решение этой задачи 2
// System.Console.Write("Введите день недели: ");
// int day = Convert.ToInt32(Console.ReadLine());

// switch (day)
// {
// case 1:
// System.Console.WriteLine("Понедельник");
// break;
// case 2:
// System.Console.WriteLine("Вторник");
// break;
// case 3:
// System.Console.WriteLine("Среда");
// break;
// case 4:
// System.Console.WriteLine("Четверг");
// break;
// case 5:
// System.Console.WriteLine("Пятница");
// break;
// case 6:
// System.Console.WriteLine("Суббота");
// break;
// case 7:
// System.Console.WriteLine("Воскресенье");
// break;
// default:
// System.Console.WriteLine("Такого дня недели не существует");
// break;
// }

// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = -N; i <=N; i++)
{
    System.Console.Write(i + " ");
}