string[] FilterShortStrings(string[] arr)
{
    int count = 0;
    // Определяем количество строк в исходном массиве, удовлетворяющих условию
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }
    // Создаем новый массив подходящего размера
    string[] result = new string[count];
    int index = 0;
    // Заполняем новый массив строками, удовлетворяющими условию
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            result[index] = arr[i];
            index++;
        }

    }
    return result;
}



// Пример задания массива на старте выполнения
string[] arr = { "Hello", "2", "world", ":-)" };

// Выводим исходный массив
Console.WriteLine("Исходный массив:");
foreach (string s in arr)
{
    Console.Write(s + " ");
}
Console.WriteLine();