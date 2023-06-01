// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// создаем текстовые переменные на удобном языке

string entermessage = "Введите целое, положительное число: ";
string continuemessage = "Для выхода нажмите '0' или введите целое, положительное число: ";
string result = "Сумма чисел от 1 до";

User(entermessage);

void User(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    CheckEnter(num);
}

void CheckEnter(int num)
{
    if (num < 0) User(continuemessage);
    else if (num == 0) return;
    else SumNumbers(num);
}

void SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    Console.WriteLine($"{result} {num} -> {sum,4}");
    User(continuemessage);
}