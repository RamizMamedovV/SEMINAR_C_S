// Задача 69. Напишите программу, которая будет принимать
//  на вход 2 числа А и В, и возводить число А в целую степень В
//  с помощью рекурсии.
//
// А= 3; В = 5 -> 243 (3)^5

Console.Write("Введите 2 числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

int res = involuteNumber(number1, number2);
System.Console.WriteLine(res);

int involuteNumber(int num1, int num2)
{
    if(num2 == 1) return num1;
    else return num1 * involuteNumber(num1, num2 -1);
}
