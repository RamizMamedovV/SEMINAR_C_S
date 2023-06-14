// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void AverageColumnSum(int[,] mtx)
{
    int sum = 0;

        for (int j = 0; j < mtx.GetLength(1); j++)
        {
            sum = 0;
            for (int i = 0; i < mtx.GetLength(0); i++)
            {
                sum += mtx[i, j];
            }
            Console.WriteLine($" Сумма столбца {j+1} = {sum}");
        }
}

int[,] matrix = ArrayMatrixIntCreater(3, 4);
ArrayMatrixIntPrint(matrix);
AverageColumnSum(matrix);