// Программа принимает на вход координаты точек x & Y и выдает их расположение

// int ImputNum1ber(string str1) //str1- выдуманное
// {
//     System.Console.WriteLine(str1);
//     return Convert.ToInt32(Console.ReadLine());
// }
//после этого код можно написать короче, чем

// System.Console.Write("Enter x:");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter y:");
// int y = Convert.ToInt32(Console.ReadLine());
//аналог этого кода код ниже


// void FindChetvert(int x1, int y1)
// {
// if (x1 > 0 && y1 > 0)
// {
//     System.Console.Write("Number 1");
// }
// else if (x1 < 0 && y1 > 0)
// {
//     System.Console.Write("Number 2");
// }
// else if (x1 < 0 && y1 < 0)
// {
//     System.Console.Write("Number 3");
// }
// else if (x1 > 0 && y1 < 0)
// {
//     System.Console.Write("Number 4");
// }
// else
// {
//     System.Console.Write("Star");
// }
// }

// int x = ImputNum1ber("Enter x: "); //имя метода выдуманное!!!
// int y = ImputNum1ber("Enter y: ");
// FindChetvert(x, y);
// FindChetvert(-8, 7);

// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти 
// (x и y).Решение может быть как сверху аналог, так и черз массив

// System.Console.WriteLine("Enter number Q: ");
// int q = Convert.ToInt32(Console.ReadLine());
// string [] array = {"x > 0, y > 0", "x < 0, y > 0", "x < 0, y < 0", "x > 0, y < 0", "NO chetverti"};
// if (q == 1)
// {
//     System.Console.WriteLine(array[0]);
// }
// else if (q == 2)
// {
//     System.Console.WriteLine(array[1]);
// }
// else if (q == 3)
// {
//     System.Console.WriteLine(array[2]);
// }
// else if (q == 4)
// {
//     System.Console.WriteLine(array[3]);
// }
// else
// {
//     System.Console.WriteLine(array[4]);
// }

// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
// расстояние = Квадратный корень ((x2-x1)^2+(y2-y1)^2)^(1/2)
// Math.Pow() - функция квадрата
// Math.Sqrt() - функция корня

// int ImputNum(string strxy) //str1- выдуманное
// {
//     System.Console.WriteLine(strxy);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int x1 = ImputNum("Enter ax: "); //имя метода выдуманное!!!
// int x2 = ImputNum("Enter ay: ");
// int y1 = ImputNum("Enter bx: ");
// int y2 = ImputNum("Enter by: ");

// //System.Console.WriteLine(Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2)));

// System.Console.WriteLine(Math.Round(Math.Pow(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2),0.5),3));

// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


    System.Console.WriteLine("Enter N: ");
    int n = Convert.ToInt32(Console.ReadLine());
//     int count = 1;
    
// while (count <= n)
// {
// System.Console.Write(Math.Pow(count,2) + " ");
// count++;
// }
for (int count=1; count<=n; count++)
{
    System.Console.Write(Math.Pow(count,2) + " ");
}
//еще вариант решения через void
// void PrintSquares(int x)
// {
// for (int i = 1; i <= x; i++)
// {
// System.Console.Write(Math.Pow(i, 2) + " ");
// }
// }

// System.Console.WriteLine("Введите число N");
// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine();
// PrintSquares(a);