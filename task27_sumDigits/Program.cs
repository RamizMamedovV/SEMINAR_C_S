// Задача 27: Напишите программу, которая
// принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


User();

void User()
{
    Console.Write("Для выхода наберите '0' или введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if(number == 0) return;
    int result = SumDigits(number);
    Console.WriteLine($"Сумма цифр числа {number} -> {result}");
    User();
}

int SumDigits(int num)
{
    int res = 0;
    while (num != 0)
    {
        res += num % 10;
        num = num / 10;
    }
    return res;
}