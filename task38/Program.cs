// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

User();

//               для удобства проверки и повторного ввода создаем 3 метода

void User()
{
    int arraySize = InputUserInt("Введите размер массива: ");
    int round = InputUserInt("Введите размер округления эл-ов массива: ");
    // int minValue = InputUserInt("Введите мин. элемент массива: ");
    // int maxValue = InputUserInt("Введите макс. элемент массива: ");

    double[] array = new double[arraySize];
    FillArray(array, rnd : round);
    Console.WriteLine();
    ArrayPrint(array);
    int max = GetArrayMaxElemIndex(array);
    int min = GetArrayMinElemIndex(array);
    Console.WriteLine();
    double result = array[max] - array[min];
    System.Console.WriteLine("Разница макс и мин: {0:F2}", result);
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

void ArrayPrint(double[] arr, string bracketSt = "[",
                     string bracketEn = "]", string sep = " | ")
{
    Console.Write(bracketSt);
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}{sep} ");
    }
    Console.WriteLine(arr[arr.Length - 1] + bracketEn);
}

int GetArrayMaxElemIndex(double[] arr)
{
    int maxElemIndex = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > arr[maxElemIndex]) maxElemIndex = i;
    }
    return maxElemIndex;
}

int GetArrayMinElemIndex(double[] arr)
{
    int minElemIndex = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < arr[minElemIndex]) minElemIndex = i;
    }
    return minElemIndex;
}

void FillArray(double[] arr, int rnd = 2, int minElem = 100, int maxElem = 1000)
{
    var ran = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = ran.NextDouble()*(maxElem - minElem)+minElem;
        arr[i] = Math.Round(num, rnd);
    }
}