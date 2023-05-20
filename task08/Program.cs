// напишите прогр. которая принимает на вход число (N) и 
// выводит все чётные числа (делися на 2 без остатка) от 1 до (N). Например:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите целое, положительное число больше нуля: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1)
{
    Console.Write($"Число '{num}' меньше '1' ");
}
else if (num == 1)
{
    Console.Write($"Нет положительных чисел в '{num}'! ");
}
else
{
    int count = 2;
    Console.Write($"{count}");
    count += 2;
    while (count <= num)
    {
        Console.Write($", {count}");
        count += 2;
    }
}