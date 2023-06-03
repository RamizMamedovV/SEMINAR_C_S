// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. 

// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

User();

void User()
{
    int arrayLength = UserPrint("Введите длину массива: ");
    int minNumber = UserPrint("Введите мин. диапозон для заполнения массива: ");
    int maxNumber = UserPrint("Введите макс. диапозон для заполнения массива: ");
    int[] array = new int[arrayLength];
    FillArray(array, minNumber, maxNumber);
    PrintArray(array);
    int sumPositive = GetPositiveSum(array);
    Console.WriteLine($"Сумма положительных элементов = {sumPositive}");
    int sumNegative = GetNegativeSum(array);
    Console.WriteLine($"Сумма отрицательных элементов = {sumNegative}");

    int checkContinue = UserPrint("Для продолжения введите '1', для выхода '0':");
    if(checkContinue == 1) User();
    else if(checkContinue == 0) return;
}

int GetPositiveSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += arr[i];
    }
    return sum;
}

int GetNegativeSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sum += arr[i];
    }
    return sum;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

void FillArray(int[] arr, int minValue = 0, int maxVal = 10)
{
    var rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minValue, maxVal + 1);
    }
}

int UserPrint(string str)
{
    Console.Write(str);
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

//     return sum;
// }
// int[] sumPositiveNegativElem = GetSumPositiveNegativElem(array);
// Console.WriteLine($"Сумма положительных элементов = {sumPositiveNegativElem[0]}");
// Console.WriteLine($"Сумма отрицательных элементов = {sumPositiveNegativElem[1]}");

// int sumPositiveElem = GetSumPositiveElem(array);
// int sumNegativeElem = GetSumNegativeElem(array);
// Console.WriteLine($"Сумма положительных элементов = {sumPositiveElem}");
// Console.WriteLine($"Сумма отрицательных элементов = {sumNegativeElem}");