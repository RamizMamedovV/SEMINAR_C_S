// напишите прогр., которая принимает на вход цифру, 
// обозначаюзую день недели и проверяет - выходной или нет. Например:
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите день недели от 1 до 7: ");
string dayOfWeek = Console.ReadLine();

string checkDay = CheckDay(dayOfWeek);
Console.Write(checkDay);

string CheckDay(string day)
{
    if(day == "1" || day == "2"
            || day == "3" || day == "4"
            || day == "5") return "нет";
    if(day == "6" || day == "7") return "да";
    return "-1";
}