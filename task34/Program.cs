// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

User();

//               для удобства проверки и повторного ввода создаем 3 метода

void User()
{
    int arraySize = InputUserInt("Введите размер массива: ");
    // int minValue = InputUserInt("Введите мин. элемент массива: ");
    // int maxValue = InputUserInt("Введите макс. элемент массива: ");

    int[] array = new int[arraySize];
    FillArray(array);
    int evenCount = EvenCounter(array);
    ArrayPrint(array);
    System.Console.WriteLine($"Количество чётных чисел в массиве: {evenCount}");
    Console.WriteLine();

    InputContinue("Введите '1' для продолжения или '0' - для выхода:");
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
        if (num == 1) User();
        else if (num == 0) return;
        else InputUserInt("Введите '1' для продолжения или '0' - для выхода:");
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

    int EvenCounter(int[] arr)
    {
        int counter = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0) counter++;
        }
        return counter;
    }

    void FillArray(int[] arr, int minElem = 100, int maxElem = 1000)
    {
        var rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(minElem, maxElem);
        }
    }