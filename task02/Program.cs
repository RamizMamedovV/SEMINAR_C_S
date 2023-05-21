// напишите прогр. которая принимает на вход 2 числа и проверяет
// какое число больше, а какое меньше. Например:
// а = 5, в = 7 -> max =7
// а = -20, в = -3 -> max = -3

Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2 ) 
{
    Console.WriteLine($"max = {num1}" );
}
else if(num1 == num2 ) 
{
    Console.WriteLine($"Вы ввели равнозначные числа! {num1} = {num2}" );
}
else 
{
    Console.WriteLine($"max = {num2}" );
}