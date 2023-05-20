// Написать программу, которая на вход принимает число и выдает его квалрат
// (число умноженное само на себя). Например:
// 4 -> 16

Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
int square = num * num;
if(num == 0) Console.WriteLine("You entered vrong num");
else Console.WriteLine($"The square of your number = {square}" );