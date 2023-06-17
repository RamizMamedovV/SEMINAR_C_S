// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] ArrayMatrixIntCreater(int rows, int colomns, int minVal = 0, int maxVal = 10)
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

void ArrayMatrixIntPrint(int[,] mtx)
{
    for (int i = 0; i < mtx.GetLength(0); i++)
    {
        for (int j = 0; j < mtx.GetLength(1); j++)
        {
            Console.Write($"{mtx[i, j],3}");
        }
        Console.WriteLine();
    }
}

int[,] MatrixRowsSum(int[,] mtx)
{
    int[,] arr = new int[2, mtx.GetLength(0)];
    int sum = 0;

    for (int i = 0; i < mtx.GetLength(0); i++)
    {
        for (int j = 0; j < mtx.GetLength(1); j++)
        {
            sum += mtx[i, j];
        }
        arr[0, i] = i;
        arr[1, i] = sum;
        sum = 0;
    }
    return arr;
}

int ArrayMinRow(int[,] arr)
{
    int min = arr[1, 0];
    int res = 0;

    for (int j = 1; j < arr.GetLength(1); j++)
    {
        if (arr[1, j] < min)
        {
            min = arr[1, j];
            res = arr[0, j];
        }
    }
    return res;
}

int[,] matrix = ArrayMatrixIntCreater(6, 4);
ArrayMatrixIntPrint(matrix);

System.Console.WriteLine();
int[,] matrixSum = MatrixRowsSum(matrix);
ArrayMatrixIntPrint(matrixSum);

System.Console.WriteLine();
int minRow = ArrayMinRow(matrixSum);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minRow}");
