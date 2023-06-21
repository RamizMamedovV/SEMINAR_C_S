// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

CheckNumbers(number1, number2);

void CheckNumbers(int num1, int num2)
{
    int sum = 0;
    if (num1 > 0 && num2 > 0)
    {
        if (num1 >= num2) sum = SumNumbers(num2, num1);
        else if (num2 > num1) sum = SumNumbers(num1, num2);
        Console.WriteLine($"Сумма натуральных элементов в промежутке"
                                        + $"от {num1} до {num2} = {sum}");
    }
    else Console.WriteLine("Не корректный ввод!");
}

int SumNumbers(int num1, int num2)
{
    if (num1 == num2) return num1;
    return num2 + SumNumbers(num1, num2 - 1);
}
