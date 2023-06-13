// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int count = 0;
while (true)
{
    Console.Write("Для вывода результат нажмите Enter или продолжайте"
                                + "вводить любое число: ");
    string user = Console.ReadLine()!;
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

// int[] ParseString(string input)
// {
//     string[] strArray = input.Split(", ");
//     int[] intArray = new int[strArray.Length];
//     for (int i = 0; i < strArray.Length; i++)
//     {
//         intArray[i] = Convert.ToInt32(strArray[i]);
//     }
//     return intArray;
// }

// Console.WriteLine("Enter several numbers as follows: <num1, num2, ..., numN>");
// string user_str = Console.ReadLine()!;

// if (user_str != string.Empty)
// {
//     int[] array = ParseString(user_str);

//     int count = 0;
//     foreach (var num in array)
//     {
//         if (num > 0) count++;
//     }

//     Console.WriteLine($"You have entered {count} positive numbers");
// }
// else
// {
//     Console.WriteLine("You have entered 0 positive numbers");
// }