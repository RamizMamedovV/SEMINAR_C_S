// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите целое число: ");
string val = Console.ReadLine();
int len = val.Length;
int number = Convert.ToInt32(val);

Console.WriteLine(ReverseNum(number, len));

string ReverseNum(int num, int l)
{
    int rnum = 0;
    for (int i = 0; i < l; i++)
    {
        rnum = rnum * 10 + num % 10;
        num = num / 10;
        Console.WriteLine(rnum);
    }
    return rnum == number ? "yes" : "no";
}