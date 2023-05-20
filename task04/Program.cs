// напишите прогр. которая принимает на вход три числа и 
// выдает максимальное из этих трёх чисел. Например:
// 2, -3, 7 -> 7

//                                  Решение в 3-х вариантах:

Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье целое число: ");
int num3 = Convert.ToInt32(Console.ReadLine());


//                                          Вариант №1

int[] array = { num1, num2, num3 };
int max = num1;
int count = array.Length;

while (count < 3)
{
    if (array[count] > max)
    {
        max = array[count];
    }
    count++;
}
Console.WriteLine($"Максимальное число = {max} ");


//                                          вариант №2

// int[] array = { num1, num2, num3 };
// int max = 0;
// int count = array.Length;

// for (int i = 0; i < count; i++)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
// }
// Console.WriteLine($"Максимальное число = {max} ");


//                                          вариант №3

// int max = num1;

// if(num2 > num1) max = num2;

// if(num3 > num1) max = num3;

// Console.WriteLine($"Максимальное число = {max} ");