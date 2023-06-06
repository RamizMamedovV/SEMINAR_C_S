// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] array = ArrayCreateFill(5);
ArrayPrint(array);
ArrayReversed(array);
ArrayPrint(array);

int[] ArrayCreateFill(int sizeNewArray, int minVal = 0, int maxVal = 100)
{
    int[] arr = new int[sizeNewArray];
    var rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minVal, maxVal);
    }

    return arr;
}

void ArrayPrint(int[] arr, string beginBracket = "[",
                         string lastBracket = "]", string sep = ",")
{
    Console.Write(beginBracket);
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]} {sep}");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}{lastBracket}");
}

void ArrayReversed(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}
