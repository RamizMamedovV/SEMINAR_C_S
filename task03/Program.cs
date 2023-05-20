// напишите прогр. которая принимает на вход порядковый номер недели и 
// выводит этот день недели на терминал. Например:
// 1 -> пн

Console.Write("Enter the number of week: ");
string numOfWeek = Console.ReadLine();

if (numOfWeek == "1") Console.Write("Mon");
else if (numOfWeek == "2") Console.Write("Tue");
else if (numOfWeek == "3") Console.Write("Wen");
else if (numOfWeek == "4") Console.Write("Thu");
else if (numOfWeek == "5") Console.Write("Fry");
else if (numOfWeek == "6") Console.Write("Sat");
else if (numOfWeek == "7") Console.Write("Sun");
else Console.Write("wrong number");