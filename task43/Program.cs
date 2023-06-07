// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Для нахождения пересечения двух прямых,"
+ " заданными уравнениями y = k1 * x + b1, y = k2 * x + b2;");

double b1 = User("Введите значение свободного члена уравнения 'b1': ");
double k1 = User("Введите коэффициент наклона 'k1': ");
double b2 = User("Введите значение свободного члена уравнения 'b2': ");
double k2 = User("Введите коэффициент наклона 'k2': ");

double[] result = new double[2];
IntersectionDot(result, k1, b1);

Console.Write($"({result[0]};{result[1]})");

double User(string str)
{
    Console.Write(str);
    double num = Convert.ToDouble(Console.ReadLine());

    return num;
}

double[] IntersectionDot(double[] arr, double cfc, double val)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = cfc * x + val;
    arr[0] = x;
    arr[1] = y;

    return arr;
}
