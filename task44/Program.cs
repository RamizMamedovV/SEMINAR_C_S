// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите число больше нуля: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0) Fibonacci(number);
else Console.WriteLine("Некорректный ввод!");

void Fibonacci(int num)
{
    int first = 0;
    int second = 1;
    if (num == 1) System.Console.WriteLine($"{first}");
    else if (num == 2) System.Console.WriteLine($"{first}{second}");
    else
    {
        int res = 0;
        Console.Write($"{first}{second}");
        for (int i = 3; i < num + 1; i++)
        {
            res = first + second;
            Console.Write(res);
            first = second;
            second = res;
        }
    }
}
