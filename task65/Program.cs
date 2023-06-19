﻿// Задача 65.Задайте значение М и N. Напишите программу, которая 
// выведит все натуральные числа в промежутке от М до N.
//
// М= 4; N = 8 -> "4,5,6,7,8"

void NaturalNumbers(int startN, int num)
{
    if (num < startN) return;
    NaturalNumbers(startN, num - 1);
    Console.Write($"{num} ");
}

Console.Write("Введите стартовое число: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(start, number);
