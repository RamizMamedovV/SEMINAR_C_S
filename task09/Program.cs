// напишите прогр. которая выводит случайное число из отрезка [10, 99] и 
// показывает наибольшую цмфру числа. Например:
// 78 -> 8

int num = new Random().Next(10, 100);
Console.Write($"Из случайного числа в дпапазоне [10, 99]: {num}, наибольшая цифра-> ");

int digital1 = num / 10;
int digital2 = num % 10;

if(digital1 > digital2) Console.Write(digital1);
else Console.Write(digital2);
