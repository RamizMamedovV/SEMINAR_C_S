﻿// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10
int num = 2;
int val = 1;
int res = 0;
while (num > 0)
{
    res += (num % 2) * val;
    val *= 10;
    num = num / 2;
}
    Console.Write(res);