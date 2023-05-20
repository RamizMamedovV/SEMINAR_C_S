// напишите прогр. которая принимает на вход 2 числа и проверяет
// является 1ое число квадратом 2ого. Например:
// а = 25, в = 5 -> да
// а = 20, в = 5 -> нет

Console.Write("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2) Console.WriteLine($"Yes, the square of {num2} = {num1}" );

else Console.WriteLine($"No, the square of {num2} isn't equal to {num1}");
