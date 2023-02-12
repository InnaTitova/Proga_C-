int[] array = { 11,21,31,41,15,61,17,18,19 };
//Console.WriteLine(array[4]); //вывод значения элемента массива
// int max = Max(
//     Max(array[0], array[1], array[2]),
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8])
// );
// Console.WriteLine(max); // код не сработал с этим преподом

//продолжим тему - найти index элемента массива, который совпадает с тем который ввел пользователь
int n = array.Length;
int find = 2;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; //если условие выполнено, то прерви операции
    }
    index ++;
}
