// Задача 25: Напишите цикл, который принимает на вход два
// числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void EnterNumber()
{
    int num = UserEnter("Для выхода наберите '0' или ведите число А для возведения в степень: ");
    if(num == 0) 
    {
        return;
    }
    else
    {
        EnterPower(num);
    }
}

void EnterPower(int num)
{
    int pow = UserEnter("Введите степень 'больше 0' для числа А: ");
    if(pow <= 0)
    {
        EnterNumber();
    }
    else
    {
        int res = PowerNumber(num, pow);
        Console.WriteLine($"{num}^ {pow} = {res}");
        EnterNumber();
    }
}

int UserEnter(string str)
{
    Console.Write(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int PowerNumber(int num, int pow)
{
    int res = num;
    for (int i = 1; i < pow; i++)
    {
        res *= num;
    }
    return res;
}

EnterNumber();