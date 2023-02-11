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

Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
{
    Console.Write("Да,число a есть квадратный корень b");
}
else
{
    Console.Write("НЕТ,число b не есть квадратный корень a");
}