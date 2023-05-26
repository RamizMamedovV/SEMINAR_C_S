// напишите прогр. которая принимает на вход число и 
// проверяет, кратно ли оно одновременно 7 и 23. Например:
// 14-> нет
// 161 -> да

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool res = DevidedByTwoNumbers(num, 7, 23);
Console.WriteLine(res ? "Да" : "Нет");

bool DevidedByTwoNumbers(int devidedByTwoNum, int num1, int num2)
{
    return devidedByTwoNum % num1 == 0 && devidedByTwoNum % num2 == 0;
}