// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).


Console.Write("Введите диапазон возможных координат от 1 до 4: ");
string range = Console.ReadLine();

string quarter = Quarter(range);
string result = quarter != null 
                ? $"Указанные координаты соответствуют четверти: {quarter}" 
                : "Введён некорректный диапазон";
Console.WriteLine(result);

string Quarter(String ran)
{
    if(ran == "1") return "x > 0 ; y > 0";
    if(ran == "2") return "x < 0 ; y > 0";
    if(ran == "3") return "x < 0 ; y < 0";
    if(ran == "4") return "x > 0 ; y < 0";
    return null;
};