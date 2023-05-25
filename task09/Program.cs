// напишите прогр. которая выводит случайное число из отрезка [10, 99] и 
// показывает наибольшую цмфру числа. Например:
// 78 -> 8

//                      неизменная часть для 3-х вариантов
int num = new Random().Next(10, 100);
Console.Write($"Из случайного числа в дпапазоне [10, 99]: {num}, наибольшая цифра-> ");


//                             1-й вариант

// int digit1 = num / 10;
// int digit2 = num % 10;
// if (digit1 > digit2) Console.WriteLine(digit1);
// else Console.WriteLine(digit2);

//                       2-й вариант: тернальный вариант

// int digit1 = num / 10;
// int digit2 = num % 10;
// Console.Write($"Из случайного числа в дпапазоне [10, 99]: {num}, наибольшая цифра-> ");
// Console.WriteLine(digit1 > digit2 ? digit1 : digit2);

//                             3-й вариант

int MaxDigit(int number)
{
    int digit1 = number / 10;
    int digit2 = number % 10;
    int maxDigit = digit1 > digit2 ? digit1 : digit2;

    return maxDigit;
}

Console.WriteLine(MaxDigit(num));