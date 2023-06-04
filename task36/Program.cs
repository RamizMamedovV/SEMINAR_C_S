// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

User();

//               для удобства проверки и повторного ввода создаем 3 метода

void User()
{
    int arraySize = InputUserInt("Введите размер массива: ");
    // int minValue = InputUserInt("Введите мин. элемент массива: ");
    // int maxValue = InputUserInt("Введите макс. элемент массива: ");

    int[] array = new int[arraySize];
    FillArray(array);
    int sumOdd = SumOddPositionElem(array);
    ArrayPrint(array);
    System.Console.WriteLine($"Сумму элементов, стоящих на нечётных позицияхе: {sumOdd}");
    Console.WriteLine();

    InputContinue("Введите '1' для продолжения или '0' - для выхода: ");
}

int InputUserInt(string str)
{
    Console.Write(str);
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

void InputContinue(string str)
{
    Console.Write(str);
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if (num == 1) User();
    else if (num == 0) return;
    else InputContinue("Введите '1' для продолжения или '0' - для выхода: ");
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

int SumOddPositionElem(int[] arr)
{
    int count = 0;
    if(arr.Length == 1) return count;
    for (int i = 1; i < arr.Length; i+=2)
    {
        count += arr[i];
    }
    return count;
}

void FillArray(int[] arr, int minElem = 0, int maxElem = 100)
{
    var rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minElem, maxElem);
    }
}