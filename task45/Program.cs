// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] array = ArrayCreaterInt();
ArrayPrintInt(array);

int[] newArray = ArrayCopyInt(array);
newArray[0] = 555;
ArrayPrintInt(newArray);

int[] ArrayCreaterInt(int sizeNum = 8, int minVal = 0, int maxVal = 10)
{
    int[] arr = new int[sizeNum];
    var rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minVal, maxVal);
    }
    return arr;
}

void ArrayPrintInt(int[] arr, string startBracket = "[", string lastBracket = "]")
{
    Console.Write(startBracket);
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}{lastBracket}");
}

int[] ArrayCopyInt(int[] arr)
{
    int[] newArr = new int[arr.Length];
    for (int i = 0; i < newArr.Length; i++)
    {
        newArr[i] = arr[i];
    }
    return newArr;
}
