// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

 PrintUser("Введите положительное число больше нуля: ");

void PrintUser(string mes)
{
    Console.WriteLine($"Для выхода нажмите '0' или {mes}");
    int number = Convert.ToInt32(Console.ReadLine());
    if(number == 0) return;
    else Tabl(number);
}

void Tabl(int num)
{
    if (num > 0)
    {
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine($"{i} -> {i * i}");
        }
            PrintUser("для продолжения введите положительное число больше нуля: ");
    }
    else
    {
        PrintUser($"Вводите только положительное число");
    }
}