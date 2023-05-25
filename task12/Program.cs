// напишите прогр. которая принимает на вход 2 числа и выводит
// является ли первое число кратным второму. Если нет, то
// программа выводит остаток от деления.
// Например:
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int remainder = Remainder(num1, num2);
if(remainder > 0) Console.Write($"не кратно, остаток: {remainder}");
else Console.Write("кратно ");

int Remainder(int number1, int number2)
{
    int res = number1 % number2;

    return res;
}