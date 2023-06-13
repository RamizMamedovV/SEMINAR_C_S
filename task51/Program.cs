// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] MatrixIntArrayCreater(int rows, int comomns, int minVal = 0, int maxVal = 10)
{
    int[,] mtx = new int[rows, comomns];
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

void MatrixIntArrayPrint(int[,] mtx)
{
    for (int i = 0; i < mtx.GetLength(0); i++)
    {
        for (int j = 0; j < mtx.GetLength(1); j++)
        {
            Console.Write($"{mtx[i, j],6}");
        }
        Console.WriteLine();
    }
}

int SumElemMatrix(int[,] mtx)
{
    int sum = 0;
    for (int i = 0; i < mtx.GetLength(0); i++)
    {
        for (int j = 0; j < mtx.GetLength(1); j++)
        {
            if(i == j) sum += mtx[i, j];
        }
    }
    return sum;
}

int[,] matrix = MatrixIntArrayCreater(4, 4);
MatrixIntArrayPrint(matrix);

int sumElem = SumElemMatrix(matrix);
Console.WriteLine($"Сумма элементов по диагонали = {sumElem}");