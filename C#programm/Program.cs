string[] InitArray()
/* Метод создания и заполнения массива
со случайной длиной и случайными элементами, состоящими из букв */
{
    Random rnd = new Random();
    int number = rnd.Next(1, 14);
    string[] result = new string[number];
    for (int i = 0; i < result.Length; i++)
    {
        int wordLength = rnd.Next(1, 10);
        for (int j = 0; j < wordLength; j++)
        {
            result[i] += (char)rnd.Next(0x0410, 0x44F);
        }
    }
    return result;
}

void PrintArray(string[] arr, string message)
//Метод выведения массива на консоль
{
    Console.WriteLine(message);
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
    Console.WriteLine();
}

string[] CreateNewArray(string[] arr)
/* Метод создания нового массива из элементов,
состоящих из трех символов и менее */
{
    string[] result = new string[arr.Length];
    for (int i = 0, j = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            result[j] = arr[i];
            j++;
        }
    }
    return result;
}
string[] arr = InitArray();
PrintArray(arr, "Случайный string массив: ");
string[] newArr = CreateNewArray(arr);
PrintArray(newArr, "Массив из элементов, состоящих из трех и менее символов: ");
