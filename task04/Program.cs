// напишите прогр. которая принимает на вход три числа и 
// выдает максимальное из этих трёх чисел. Например:
// 2, -3, 7 -> 7

Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье целое число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int[] array = { num1, num2, num3 };

int max = num1;
int count = 0;

while (count < 3)
{
    if (array[count] > max)
    {
        max = array[count];
    }
    count++;
}
Console.WriteLine($"Максимальное число = {max} ");
