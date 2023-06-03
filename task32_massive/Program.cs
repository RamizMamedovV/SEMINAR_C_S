// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

User();

void User()
{
    int arraySize = InputUserInt("Введите размер массива: ");
    int minValue = InputUserInt("Введите мин. значение массива: ");
    int maxValue = InputUserInt("Введите макс. значение массива: ");
    string startBracket = InputUserString("Введите знак скобки начала массива: ");
    string endBracket = InputUserString("Введите знак скобки конца массива: ");
    string separateSymbol = InputUserString("Введите знак разделения элементов массива: ");

    int[] array = CreateArray(arraySize, maxValue, maxValue);
    ArrayPrint(array,startBracket, endBracket, separateSymbol);
    ArrayInversion(array);
    ArrayPrint(array,startBracket, endBracket, separateSymbol);

    InputUserInt("Введите 1 для продолжения или 2 - для выхода:");
}

void InpupContinue(string str)
{
    Console.Write(str);
    int num = Convert.ToInt32(Console.ReadLine());
    if(num == 1) User();
    else if(num == 0) return;
    else InputUserInt("Введите 1 для продолжения или 2 - для выхода:");
}

string InputUserString(string str)
{
    Console.Write(str);
    string inputUser = Console.ReadLine();

    return inputUser;
}

int InputUserInt(string str)
{
    Console.Write(str);
    string inputUser = Console.ReadLine();
    int num = Convert.ToInt32(inputUser);

    return num;
}

void ArrayPrint(int[] arr, string bracketSt = "[",
                     string bracketEn = "]", string sep = ", ")
{
    Console.Write(bracketSt);
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} {sep}");
    }
    Console.WriteLine(bracketEn);
}

void ArrayInversion(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}

int[] CreateArray(int size = 10, int minElem = -9, int maxElem = 9)
{
    int[] arr = new int[size];
    var rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minElem, maxElem + 1);
    }
    return arr;
}