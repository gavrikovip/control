//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

//Метод печати массива не выводя пустые строки

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] != null)
        Console.Write($" '{arr[i]}'");
    }
    Console.Write(" ]");
}

// Задаем массив
string[] arrayData = {"hello", "2", "world", ":-)"};

// Добавление строк, длина которых небольше 3 символов, в новый массив 
string[] arrayFinal = new string[arrayData.Length];
for (int i = 0; i < arrayData.Length; i++)
{
    if(arrayData[i].Length <= 3)
    {
        arrayFinal[i] = arrayData[i];
    }
   
}

