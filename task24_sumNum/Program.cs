// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

string entermessage = "Введите целое, положительное число: ";
string continuemessage = "Для выхода нажмите '0' или введите целое, положительное число: ";
//string continuemessage = "Для выхлда нажмите '0' или введите целое, положительное число: ";

User(entermessage);

void User(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    CheckEnter(num);
}

// void User(int val, int num)
// {
//     Console.WriteLine($"{val,3} -> {num,4}");
//     User(continuemessage);
// }

void CheckEnter(int num)
{
    if (num < 0) User(continuemessage);
    else if (num == 0) return;
    else SumNumber(num);
}

void SumNumber(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
        Console.WriteLine($"{i, 3} -> {sum,4}");
    }
    User(continuemessage);
}