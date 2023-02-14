//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

// string text = "— Я думаю, — сказал князь, улыбаясь, — что, ежели бы вас послали вместо нашего милого Винценгероде,” вы бы взяли приступом согласие прусского короля. Вы так красноречивы. Вы дадите мне чаю?";
// string Replace(string text, char oldValue, char newValue)
// {
// string result = String.Empty; //пустая строка
// int length = text.Length;
// for (int i = 0; i < length; i++)
// {
//    if(text[i] == oldValue) result = result + $"{NewValue}";
//    else result = result + $"{text[i]}";
// }
// return result;
// }
// string newText = Replace(text, " ", "|");
// Console.WriteLine(newText);
// Ищи ошибки в коде ---Задача НЕ ВЫПОЛНЯЕТСЯ-----------

// Этот вариант скинули на форуме
// Console.Clear();
// string text = "несет самостоятельную ответственность по своим обязательствам, может от своего имени"
// + "приобретать и осуществлять имущественные и личные неимущественные права, исполнять"
// + "обязанности, быть истцом и ответчиком в суде. НКФО имеет самостоятельный баланс";
// string text_char = $"{text[0]}";
// string Replace(string text, char oldValue, char newValue)
// {
// string result = String.Empty;

// int length = text.Length;
// for (int i = 0; i < length; i++)
// {
//     if(text[i] == oldValue) result = result + $"{newValue}";
//     else result = result + $"{text[i]}";
// }
// return result;
// }
// string newText = Replace(text, ' ', '|');
// string newText1 = Replace(newText, 'п', 'П');
// string newText2 = Replace(newText1, 'с', 'С');
// System.Console.WriteLine(newText2);

// Вариант требует проверки!!!



// Задача упорядочить массив от меньшего к большему --
// КОД РАБОТАЕТ!!!!!!

// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
// void PrintArray(int[] array)
// {
//     int count = array.Length;
// for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{ array[i]}");
// }
// Console.WriteLine();
// }
// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) 
//             {
//                 minPosition = j;
//             }
//         }
//         int temporary = array[i];
//     array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }
// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);

//Задача упорядочить массив от БОЛЬШЕГО к МЕНЬШЕМУ --
// КОД РАБОТАЕТ!!!!!!

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 98, 78 };
void PrintArray(int[] array)
{
    int count = array.Length;
for (int i = 0; i < count; i++)
    {
        Console.Write($"{ array[i]}, "); //тут сделала пробел между цифрами
}
Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) 
            {
                maxPosition = j;
            }
        }
        int temporary = array[i];
    array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);




