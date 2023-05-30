// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// для ввода и вывода текста создаем текст на удобном языке
string entermessage = "Введите целое число: ";
string yes = "-> Верно, является палиндромом";
string no = "Нет, не является палиндромом";

User(entermessage);


void User(string str)
{
    Console.Write(str);
    string val = Console.ReadLine();
    int len = CheckValue(val);
    int number = Convert.ToInt32(val);
    int res = ReverseNum(number, len);
    if(res == number) Console.WriteLine($"{res} {yes}");
    else Console.WriteLine($"{res} {no}");
    //User(entermessage);                 
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

int CheckValue(string txt)
{
    for (int i = 0; i < txt.Length; i++)
    {
        if (txt[i] == '-') return txt.Length - 1;
    }
    return txt.Length;
}