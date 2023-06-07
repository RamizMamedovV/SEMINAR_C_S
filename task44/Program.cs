// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите число больше нуля: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    if (number == 1)
    {
        int[] array1 = new int[1];
        ArrayPrintInt(array1);
    }
    else
    {
        int[] array = FibonacciArrayCreaterInt(number);
        ArrayPrintInt(array);
    }
}
else
{
    Console.WriteLine("Некорректный ввод!");
}
//if (number > 0) Fibonacci(number);
// else Console.WriteLine("Некорректный ввод!");
// void Fibonacci(int num)
// {
//     int first = 0;
//     int second = 1;
//     if (num == 1) System.Console.WriteLine($"{first}");
//     else if (num == 2) System.Console.WriteLine($"{first}{second}");
//     else
//     {
//         int res = 0;
//         Console.Write($"{first}{second}");
//         for (int i = 3; i < num + 1; i++)
//         {
//             res = first + second;
//             Console.Write(res);
//             first = second;
//             second = res;
//         }
//     }
// }

int[] FibonacciArrayCreaterInt(int sizeNum = 8)
{
    int[] arr = new int[sizeNum];
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
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
