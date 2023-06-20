// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

PrintConsecutiveDigits(number);

void PrintConsecutiveDigits(int num)
{
    if (IsNaturalNumber(num))
    {
        Console.Write($"N = {num} -> ");
        Console.Write("'");
        ConsecutiveDigits(num);
        Console.Write("'");
    }
    else Console.WriteLine("Введено не натуральное число!");
}

bool IsNaturalNumber(int num)
{
    return num > 0 ? true : false;
}

void ConsecutiveDigits(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    ConsecutiveDigits(num - 1);
}
