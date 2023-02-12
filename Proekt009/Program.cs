//работа с массивом, рандомные числа
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.Write(col[position]);
        position++;
    }
}

int Indexof(int[]collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // если нет элемента на позиции, то будет показывать -1 (можно -2 ит.д.)это лишь обозначение отсутсвия позиции
    while (index < count)
    {
        if (collection[index] == find)
        {
          position = index;
          break; //нашли первую позицию и больше не проверяем
        }
        index++;
    }
    return position;
}

int[] array = new int [10];
FillArray(array);
array[4]=4; //принудительно поставили на 4 позиции 4
PrintArray(array);
System.Console.WriteLine();

int pos = Indexof(array, 5); //вручную задали показать  позицию цифры 5
System.Console.WriteLine(pos);
