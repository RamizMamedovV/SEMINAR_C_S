// напишите прогр. которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цмфру этого числа. Например:
// 782 -> 8
// 192 -> 9

Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool res = IsThreeDigits(num);
Console.WriteLine(res
            ? $"Вторая цмфра этого числа: {SecondDigit(num)}"
            : "Вы ввели не трёхзначное число: ");

int SecondDigit(int number)
{
    int res = number / 10 % 10;
    return res;
}


bool IsThreeDigits(int val)
{
    return val > 99 && val < 1000 
            || val < -99 && val > -1000 
            ? true : false;
}