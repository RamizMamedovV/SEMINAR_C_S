﻿// напишите прогр. которая принимает на вход число и 
// выводит эявляется ли число чётным(делися на 2 без остатка). Например:
// 4 -> да
// -3 -> нет

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int res = num % 2;
if(res == 0) Console.Write($"Да, число '{num}' является чётным ");
else Console.Write($"Нет, число '{num}' не является чётным ");