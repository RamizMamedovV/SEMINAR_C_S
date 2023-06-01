// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// создаем текстовые переменные на удобном языке

string entermessage = "Введите целое число: ";
string yes = "-> Верно, является палиндромом";
string no = "-> Нет, не является палиндромом";

User(entermessage);


void User(string str)
{
    Console.Write(str);
    int number = Convert.ToInt32(Console.ReadLine());
    int len = CheckLength(number);
    int res = ReverseNum(number, len);
    if(res == number) Console.WriteLine($"{res} {yes}");
    else Console.WriteLine($"{res} {no}");
    User(entermessage);                 
     //мспользуется для рекурсии. в эом случае, для прерывания одновременно нажмите ctrl + c 
}

int ReverseNum(int num, int l)
{
    int rnum = 0;
    for (int i = 0; i < l; i++)
    {
        rnum = rnum * 10 + num % 10;
        num = num / 10;
    }
    return rnum;
}


int CheckLength(int num)
{
    int count = 0;
    while(num != 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

