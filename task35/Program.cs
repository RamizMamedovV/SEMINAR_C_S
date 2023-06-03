// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

User();

void User()
{
    int[] array = CreateArray();
    ArrayPrint(array);

    int countElem = FindCountElem(array);
    Console.WriteLine($"Количество элементов в диапозоне [10,99] = {countElem}");
    InputContinue("Введите 1 для продолжения или 2 - для выхода:");
}

void InputContinue(string str)
{
    Console.Write(str);
    int num = Convert.ToInt32(Console.ReadLine());
    if (num == 1) User();
    else if (num == 2) return;
    else InputUserInt("Введите 1 для продолжения или 2 - для выхода:");
}

int InputUserInt(string str)
{
    Console.Write(str);
    string inputUser = Console.ReadLine();
    int num = Convert.ToInt32(inputUser);

    return num;
}

int FindCountElem(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 9 && arr[i] < 100) count++;
    }
    return count;
}

void ArrayPrint(int[] arr, string bracketSt = "[",
                     string bracketEn = "]", string sep = ", ")
{
    Console.Write(bracketSt);
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}{sep} ");
    }
    Console.WriteLine(arr[arr.Length - 1] + bracketEn);
}

int[] CreateArray(int size = 123, int minElem = -9, int maxElem = 200)
{
    int[] arr = new int[size];
    var rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minElem, maxElem + 1);
    }
    return arr;
}