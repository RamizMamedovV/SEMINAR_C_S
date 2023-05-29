// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.

// double d = Math.Sqrt(5);
// double num = 5.099874453;
// double dRound = Math.Round(num, 2, MidpointRounding.ToZero);
// System.Console.WriteLine(dRound);

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты превой 'A' точки ");
Console.Write("X: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int Ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты превой 'B' точки ");
Console.Write("X: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int By = Convert.ToInt32(Console.ReadLine());

double distance = Distance2D(Ax, Ay, Bx, By);
double result = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine(result);

double Distance2D(int ax, int ay, int bx, int by)
{
    double res = Math.Sqrt((bx - ax)* (bx - ax) + (by - ay)* (by - ay));

    return res;
}