// Задача 63.Задайте значение N. Напишите программу, которая 
// выведит все натуральные числа в промежутке от 1 до N.
//
// N = 5 -> "1,2,3,4,5"

void NaturalNumbers(int num)
{
    if (num == 0) return;
    NaturalNumbers(num - 1);
    Console.Write($"{num} ");
}

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number);
