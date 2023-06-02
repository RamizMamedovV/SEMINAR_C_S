// Задача 29: Напишите программу, которая задаёт массив из 
// 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int length = 4, int randomSize = 100)
{
    var rnd = new Random();
    int[] arr = new int[length];
    for (int i = 0; i < length - 1; i++)
    {
        arr[i] = rnd.Next(randomSize);
    }
    return arr;
}

void ArrayPrint(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
        Console.WriteLine();
}

void User()
{
    Console.Write("Введите длину массива: ");
    int arrayLength = int.Parse(Console.ReadLine());
    Console.Write("Введите диапозон чисел: ");
    int rndSize = int.Parse(Console.ReadLine());
    int[] array = CreateArray(arrayLength, rndSize);
    ArrayPrint(array);
    Console.Write("Для продолжения нажмите '1', для выхода '0': ");
    int userCheck = int.Parse(Console.ReadLine());
    if(userCheck == 1) User();
    else if(userCheck == 0) return;
}

User();