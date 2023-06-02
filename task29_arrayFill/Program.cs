// Задача 29: Напишите программу, которая задаёт массив из 
// 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void CreateArray(int[] arr, int length = 4, int randomSize = 100)
{
    var rnd = new Random();
    for (int i = 0; i < arr.Length - 1; i++)
    {
        arr[i] = rnd.Next(randomSize);
    }
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
    Console.Write("Введите диапозон чисел для массива от '0' до -> ");
    int rndSize = int.Parse(Console.ReadLine());
    int[] array = new int[arrayLength];
    CreateArray(array, rndSize);
    ArrayPrint(array);
    Console.Write("Для продолжения нажмите '1', для выхода '0': ");
    int userCheck = int.Parse(Console.ReadLine());
    if(userCheck == 1) User();
    else if(userCheck == 0) return;
}

User();