// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

User();

void User()
{
    int arraySize = InputUserInt("Введите размер массива: ");
    int minValue = InputUserInt("Введите мин. элемент массива: ");
    int maxValue = InputUserInt("Введите макс. элемент массива: ");
    int findValue = InputUserInt("Введите искомое элемент массива: ");
    string startBracket = InputUserString("Введите знак скобки начала массива: ");
    string endBracket = InputUserString("Введите знак скобки конца массива: ");
    string separateSymbol = InputUserString("Введите знак разделения элементов массива: ");

    int[] array = CreateArray(arraySize, minValue, maxValue);
    ArrayPrint(array,startBracket, endBracket, separateSymbol);

    Console.WriteLine (FindValue(array, findValue) 
                            ? $"Да, массив содержит цифру '{findValue}'" 
                                : $"Нет, массив не содержит цифру '{findValue}'");

    InputContinue("Введите 1 для продолжения или 2 - для выхода:");
}

void InputContinue(string str)
{
    Console.Write(str);
    int num = Convert.ToInt32(Console.ReadLine());
    if(num == 1) User();
    else if(num == 2) return;
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
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}{sep} ");
    }
    Console.WriteLine(arr[arr.Length-1] + bracketEn);
}

bool FindValue(int[] arr, int val)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == val) return true;
    }
    return false;
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