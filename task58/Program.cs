// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            Console.Write($"{mtx[i, j],4}");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiple(int[,] mtx1, int[,] mtx2)
{
    int pow = 0;
    int res = 0;
    int columnQuantity = mtx1.GetLength(1);
    int rowsQuantity = mtx2.GetLength(0);

    bool allower = MatrixMultipleAllower(columnQuantity, rowsQuantity);

    int[,] matxMultiple = new int[mtx1.GetLength(0), mtx2.GetLength(1)];

    if (allower == true)
    {
        for (int j = 0; j < matxMultiple.GetLength(0); j++)
        {

            for (int m = 0; m < mtx2.GetLength(1); m++)
            {
                pow = 0;
                res = 0;
                for (int n = 0; n < mtx2.GetLength(0); n++)
                {
                    pow =  mtx1[j, n] * mtx2[n, m];
                    res += pow;
                }
                matxMultiple[j, m] = res;
            }
        }
    }
    return matxMultiple;
}

bool MatrixMultipleAllower(int columnQuantity, int rowsQuantity)
{
    return columnQuantity == rowsQuantity ? true : false;
}


int[,] matrix1 = MatrixIntCreater(4, 3, 1, 5);
MatrixIntPrint(matrix1);

System.Console.WriteLine("*");

int[,] matrix2 = MatrixIntCreater(3, 2, 1, 5);
MatrixIntPrint(matrix2);

System.Console.WriteLine("=");

int[,] matrixM = MatrixMultiple(matrix1, matrix2);
MatrixIntPrint(matrixM);
