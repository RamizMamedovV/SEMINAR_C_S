// Задача 23
// Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

string entermessage = "введите целое число больше нуля: ";
string exit = "Для выхода нажмите '0' или ";
string continuemessage = "для продолжения введите положительное число больше нуля: ";
string warning = "вводите ТОЛЬКО положительное число: ";

UserEnter(exit, entermessage);

void UserEnter(string str1, string str2)
{
    Console.Write(str1 + str2);
    int number = Convert.ToInt32(Console.ReadLine());

    if(number == 0) return;
    else CubicTable(number);
}

void CubicTable(int num)
{
    if (num > 0)
    {
        Console.WriteLine($"{num} ->");
        for (int i = 1; i <= num; i++)
        {
            
            Console.WriteLine($"{i,3} | {i * i * i,4}");
        }
        UserEnter(exit, continuemessage);
    }
    else UserEnter(exit, warning);
}