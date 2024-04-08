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
}


// Пример задания массива на старте выполнения
string[] arr = { "Hello", "2", "world", ":-)" };