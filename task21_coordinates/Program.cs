// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// для ввода и вывода текста создаем текст на удобном языке

string xofa = "Введите координаты X для точки А: ";
string yofa = "Введите координаты Y для точки А: ";
string zofa = "Введите координаты Z для точки А: ";

string xofb = "Введите координаты X для точки B: ";
string yofb = "Введите координаты Y для точки B: ";
string zofb = "Введите координаты Z для точки B: ";

string checkcontinue = "Нажмите '1' для продолжения или '2' для выхода: ";
string rounvalue = "Введите количество цифр для округления после запятой: ";

UserPrint();

void CheckContinue()
{
    Console.Write($"{checkcontinue}");
    string str = Console.ReadLine();
    if(str == "1") UserPrint();
    else if(str == "2") return;
    else CheckContinue();
}

void UserPrint()
{
    Console.Write(xofa);
    int ax = Convert.ToInt32(Console.ReadLine());
    Console.Write(yofa);
    int ay = Convert.ToInt32(Console.ReadLine());
    Console.Write(zofa);
    int az = Convert.ToInt32(Console.ReadLine());

    Console.Write(xofb);
    int bx = Convert.ToInt32(Console.ReadLine());
    Console.Write(yofb);
    int by = Convert.ToInt32(Console.ReadLine());
    Console.Write(zofb);
    int bz = Convert.ToInt32(Console.ReadLine());
    Console.Write(rounvalue);
    int rv = Convert.ToInt32(Console.ReadLine());

    Distance3D(ax, ay, az, bx, by, bz, rv);

}

void Distance3D(int ax, int ay, int az, int bx, int by, int bz, int rv)
{
    double distance = Math.Sqrt((bx -ax)*(bx -ax) + (by - ay)*(by - ay) +
                                     (bz - az)*(bz - az));
    double result = Math.Round(distance, rv, MidpointRounding.ToZero);
    Console.WriteLine($" -> {result}");
    CheckContinue();
}