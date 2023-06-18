// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] MatrixIntCreater(int rows, int colomns, int minVal = 0, int maxVal = 10)
{
    int[,] mtx = new int[rows, colomns];
    Random rnd = new Random();

    for (int i = 0; i < mtx.GetLength(0); i++)
    {
        for (int j = 0; j < mtx.GetLength(1); j++)
        {
            mtx[i, j] = rnd.Next(minVal, maxVal);
        }
    }

    return mtx;
}

void MatrixIntPrint(int[,] mtx)
{
    for (int i = 0; i < mtx.GetLength(0); i++)
    {
        for (int j = 0; j < mtx.GetLength(1); j++)
        {
            Console.Write($"{mtx[i, j], 3}");
        }
        Console.WriteLine();
    }
}

void ArrayPrintInt(int[] arr, string startBracket = "[", string lastBracket = "]")
{
    Console.Write(startBracket);
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}{lastBracket}");
}

int[] MatrixRowsSum(int[,] mtx)
{
    int[] arr = new int[mtx.GetLength(0)];
    int sum = 0;

    for (int i = 0; i < mtx.GetLength(0); i++)
    {
        for (int j = 0; j < mtx.GetLength(1); j++)
        {
            sum += mtx[i, j];
        }
        arr[i] = sum;
        sum = 0;
    }
    return arr;
}

int ArrayMinIndex(int[] arr)
{
    int min = arr[0];
    int res = 0;

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            res = i;
        }
    }
    return res;
}

int[,] matrix = MatrixIntCreater(6, 4, -9, 9);
MatrixIntPrint(matrix);

System.Console.WriteLine();
int[] arraySum = MatrixRowsSum(matrix);
ArrayPrintInt(arraySum);

System.Console.WriteLine();
int minIndex = ArrayMinIndex(arraySum);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minIndex}");
