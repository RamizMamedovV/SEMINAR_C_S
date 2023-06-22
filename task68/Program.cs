// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    
    if (m > 0 && n == 0) return Ackermann(m - 1, 1);
    
    return Ackermann(m - 1, Ackermann(m, n - 1));
}

int ackerman = Ackermann(2, 3);
Console.WriteLine($"Результат функции Аккермана: {ackerman}");