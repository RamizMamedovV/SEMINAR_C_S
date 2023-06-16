// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void MatrixDescendedRows(int[,] mtx)
{
    int maxVal = 0;
    int temp = 0;
    int count = 0;
    int maxRow = 0;
    int maxCol = 0;
    for (int i = 0; i < mtx.GetLength(0); i++)
    {
        count = 0;
        maxVal = mtx[i, count];
        //Console.WriteLine($"maxVal: {maxVal}, count: {count}");
        while (count < mtx.GetLength(1) - 1)
        {
            for (int j = count; j < mtx.GetLength(1); j++)
            {
               // Console.WriteLine($"maxVal: {maxVal}, count and j: {count}");
                if (mtx[i, j] > maxVal)
                {
                    maxVal = mtx[i, j];
                    maxRow = i;
                    maxCol = j;
                }
            }
            temp = mtx[i, count];
            mtx[i, count] = maxVal;
            mtx[maxRow, maxCol] = temp;
            count++;
            maxVal = mtx[i, count];

            //ArrayMatrixIntPrint(mtx);
            //Console.WriteLine($"maxVal: {maxVal}, count and j: {count}");
        }
    }
}

int[,] matrix = ArrayMatrixIntCreater(3, 4);
ArrayMatrixIntPrint(matrix);

MatrixDescendedRows(matrix);
Console.WriteLine();
ArrayMatrixIntPrint(matrix);
