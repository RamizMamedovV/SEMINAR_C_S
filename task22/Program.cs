// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

 string exit = "Для выхода нажмите '0' или ";
 string message = "введите положительное число больше нуля: ";
 string mes = "для продолжения введите положительное число больше нуля: ";
 string warning = "вводите только положительное число: ";

PrintUser(exit, message);

void PrintUser(string mes1, string mes2)
{
    Console.WriteLine($"{mes1 + mes2}");
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
            Console.WriteLine($"{i, 3} -> {i * i, 4}");
        }
            PrintUser(exit, mes);
    }
    else
    {
        PrintUser(exit, warning);
    }
}