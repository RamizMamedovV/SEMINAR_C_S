// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int count = 0;
while (true)
{
    Console.Write("Для вывода результат нажмите Enter или продолжайте вводить любое число: ");
    string user = Console.ReadLine();
    if (user != String.Empty)
    {
        int res = Convert.ToInt32(user);
        if (res > 0) count++;
    }
    else if (user == String.Empty)
    {
        Console.WriteLine($"Вы ввели {count} положительных числа");
        return;
    }
}