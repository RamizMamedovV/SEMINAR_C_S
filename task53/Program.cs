// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int[,] MatrixIntCreator(int rows, int comumns, int minVal = 0, int maxVal = 10)
{
    int[,] mtx = new int[rows, comumns];
    var rnd = new Random();

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
            System.Console.Write($"{mtx[i, j], 3}");
        }
        System.Console.WriteLine();
    }
}

void ChangeFirstLastRows(int[,] mtx)
{
    int temp = 0;
    int firstRow = 0;
    int laststRow = mtx.GetLength(0) - 1;
    for (int j = 0; j < mtx.GetLength(1); j++)
    {
        temp = mtx[firstRow, j];
        mtx[firstRow, j] = mtx[laststRow, j];
        mtx[laststRow, j] = temp;
    }
}

int[,] matrix = MatrixIntCreator(3, 4);
MatrixIntPrint(matrix);

System.Console.WriteLine();
ChangeFirstLastRows(matrix);
MatrixIntPrint(matrix);

