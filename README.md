Первая часть кода - это определение метода FilterShortStrings, который принимает в качестве аргумента массив строк arr и возвращает новый массив строк, удовлетворяющих условию.

string[] FilterShortStrings(string[] arr){   
    int count = 0; // Переменная для подсчета числа строк, удовлетворяющих условию
    
    // Подсчет числа строк, длина которых не превышает три символа
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }
    
    // Создание нового массива подходящего размера
    string[] result = new string[count];
    int index = 0; // Индекс для заполнения нового массива
    
    // Заполнение нового массива строками, длина которых не превышает три символа
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            result[index] = arr[i];
            index++;
        }
    }
    
    return result; // Возвращаем отфильтрованный массив строк
}


После определения метода FilterShortStrings следует пример использования этого метода, где создается исходный массив строк arr, затем он фильтруется, и результат выводится на консоль.

Пример задания массива на старте выполнения: 

string[] arr = { "Hello", "2", "world", ":-)" };


Вывод исходного массива:

Console.WriteLine("Исходный массив:");

foreach (string s in arr)

{
    
    Console.Write(s + " ");

}

Console.WriteLine();


Фильтрация массива и вывод результата:

string[] filteredArr = FilterShortStrings(arr);

Console.WriteLine("Новый массив из строк, длина которых меньше или равна 3 символам:");

foreach (string s in filteredArr)

{
    
    Console.Write(s + " ");

}

Console.WriteLine();







