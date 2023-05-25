// напишите прогр. которая выводит случайное число из отрезка [10, 99] и 
// показывает наибольшую цмфру числа. Например:
// 78 -> 8

int num = new Random().Next(10, 100);
Console.Write($"Из случайного числа в дпапазоне [10, 99]: {num}, наибольшая цифра-> ");

int digit1 = num / 10;
int digit2 = num % 10;

if (digit1 > digit2) Console.Write(digit1);
else Console.Write(digit2);
