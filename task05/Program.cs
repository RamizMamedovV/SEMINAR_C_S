// напишите прогр. которая принимает на вход число (N) и 
// выводит все целые числа от -N до N и на терминал. Например:
// 4 -> "-4, -3,....3, 4"

Console.Write("Enter some number: ");
int num = Convert.ToInt32(Console.ReadLine());

int i = -num;

if (num > 0)
    while (i <= num)
    {
        Console.Write($"{i++}, ");
        //++i;
    }
else Console.Write("wrong number");