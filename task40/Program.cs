// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine(IsTriangle(55, 4, 4) ? "yes" : "no");

bool IsTriangle(int sideA, int sideB, int sideC)
{
    return sideA < sideB + sideC && sideB < sideA + sideC && sideC < sideB + sideA;
}
