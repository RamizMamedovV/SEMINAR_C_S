// напишите прогр. которая выводит случайное трехзначное число и 
// пудаляет вторую цмфру этого числа. Например:
// 768 -> 78

int num = new Random().Next(100, 1000);
Console.WriteLine($"Трёхзначное число: {num}-> ");
int delSecondDigit = DeleteSecondDigit(num);
Console.Write($"Число без второй цифры: {delSecondDigit}");

int DeleteSecondDigit(int number)
{
int dig1 = number / 100;
int dig3 = number % 10;

    return dig1 * 10 + dig3;
}

