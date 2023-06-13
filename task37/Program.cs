// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

User();

void User()
{
    int arraySize = InputUserInt("Введите размер массива: ");
    // int minValue = InputUserInt("Введите мин. элемент массива: ");
    // int maxValue = InputUserInt("Введите макс. элемент массива: ");

    int[] array1 = CreateArray(arraySize);
    ArrayPrint(array1);

    int midl = array1.Length % 2;
    if (midl == 0)
    {
        int l = array1.Length / 2;
        int[] array2 = new int[l];
        ProductElem(array1, array2);
        ArrayPrint(array2);
        InputContinue("Введите 1 для продолжения или 2 - для выхода:");
    }
    else
    {
        int l = array1.Length / 2 + 1;
        int[] array2 = new int[l];
        array2[array2.Length -1] = array1[l-1];
        ProductElem(array1, array2);
        ArrayPrint(array2);
        InputContinue("Введите 1 для продолжения или 2 - для выхода:");
    }


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
    string inputUser = Console.ReadLine()!;
    int num = Convert.ToInt32(inputUser);

    return num;
}

void ProductElem(int[] arr1, int[] arr2)
{
    int i = 0;
    int a = 0;
    int b = arr1.Length - 1;
    while (b != a && b > a)
    {
        Console.WriteLine(a + " " + b);
        arr2[i] = arr1[a] * arr1[b];
        a++;
        b--;
        i++;
    }
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


int[] CreateArray(int size = 10, int minElem = 0, int maxElem = 9)
{
    int[] arr = new int[size];
    var rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minElem, maxElem + 1);
    }
    return arr;
}