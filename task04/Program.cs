// напишите прогр. которая принимает на вход три числа и 
// выдает максимальное из этих трёх чисел. Например:
// 2, -3, 7 -> 7

//                                  Решение в 3-х вариантах:

// неизменный блок для 3х вариантов
Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье целое число: ");
int num3 = Convert.ToInt32(Console.ReadLine());


//                                          Вариант №1 

int max = num1;

if(num2 > max) max = num2;

if(num3 > max) max = num3;

Console.WriteLine($"Максимальное число = {max} ");


//                                          вариант №2

// int[] array = { num1, num2, num3 };
// int max = num1;
// int count = array.Length;

// for (int i = 1; i < count; i++)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
// }
// Console.WriteLine($"Максимальное число = {max} ");



//                                          вариант №3

// int[] array = { num1, num2, num3 };
// int max = num1;
// int count = 1;

// while (count < array.Length)
// {
//     if (array[count] > max)
//     {
//         max = array[count];
//     }
//     count++;
// }
// Console.WriteLine($"Максимальное число = {max} ");