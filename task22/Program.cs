// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

 PrintUser("Введите число 'положительное число больше нуля: ");

void PrintUser(string mes)
{
    Console.WriteLine(mes);
    int number = Convert.ToInt32(Console.ReadLine());
    Tabl(number);
}

void Tabl(int num)
{
    if (num > 0)
    {
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine($"{i} -> {i * i}");
        }
    }
    else
    {
        Console.WriteLine($"Введите только положительное число");
    }
}