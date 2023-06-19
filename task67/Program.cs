// Задача 67.Напишите программу, которая будет принимать
//  на вход 2 числа и возвращать сумму его цифр.
//
// 453 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumDigitsRecursion(number);
System.Console.WriteLine($"Сумма цифр в числе {number} = {result}");

int SumDigitsRecursion(int num)
{
    int sum = 0;
    if (num == 0) return;
    sum += num % 10;
    SumDigitsRecursion(num / 10);

    return sum;
}

// int SumDigitsRecursion(int num)
// {
//     int sum = 0;
//     int n = num;
//     while (n > 0)
//     {
//         sum += n % 10;
//         n = n / 10;
//     }

//     return sum;
// }
