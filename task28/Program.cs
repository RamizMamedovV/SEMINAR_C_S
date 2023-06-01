// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

User();

void User()
{
    Console.Write("Для выхода нажмите '0' или введите положительное число больше нуля: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number == 0) 
    {
        return;
    }
    else if(number < 0)
    {
         User();
    }
    else
    {int result = Factorial(number);
    Console.WriteLine($"произведение чисел от 1 до {number} -> {result}");
    User();
    }
}

int Factorial(int num)
{
    int res = 1;
    for (int i = 2; i <= num; i++)
    {
        res *= i;
    }
    return res;
}