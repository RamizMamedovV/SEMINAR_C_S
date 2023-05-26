// напишите прогр. которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет. Например:
// 728 -> 8
// 19 -> третьей цифры нет

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool check = IsThreeDigits(num);
Console.WriteLine(check ? ThirdDigit(num) : "Третьей цифры нет");

bool IsThreeDigits(int val)
{
    return val > 99 || val < -99 ? true : false;
}

int ThirdDigit(int number)
{
    while(number > 999)
    {
        number = number / 10;
    }
    number %= 10; 
    return number;
}