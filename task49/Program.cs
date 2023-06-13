// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

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
            Console.Write($"{mtx[i, j], 3}");
        }
        Console.WriteLine();
    }
}

void ChangeValToPower(int[,] mtx)
{
    for (int i = 0; i < mtx.GetLength(0); i+=2)
    {
        for (int j = 0; j < mtx.GetLength(1); j+=2)
        {
            mtx[i, j] *= mtx[i, j];
        }
    }
}

int[,] matrix = ArrayMatrixIntCreater(3,4);
ArrayMatrixIntPrint(matrix);
Console.WriteLine();
ChangeValToPower(matrix);
ArrayMatrixIntPrint(matrix);
