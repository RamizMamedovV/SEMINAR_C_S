// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixMultiple(int[,] mtx1, int[,] mtx2)
{

    int pow = 0;
    int res = 0;

    int[,] matxMultle = new int[mtx1.GetLength(0), mtx1.GetLength(1)];

    for (int j = 0; j < matxMultle.GetLength(1); j++)
    {

        for (int m = 0; m < mtx2.GetLength(1); m++)
        {
            pow = 0;
            res = 0;
            for (int n = 0; n < mtx2.GetLength(0); n++)
            {
                pow = mtx2[n, m] * mtx1[j, n];
                res += pow;
            }
            matxMultle[j, m] = res;
        }

    }

    return matxMultle;
}

int[,] matrix1 = ArrayMatrixIntCreater(3, 3);
System.Console.WriteLine();
ArrayMatrixIntPrint(matrix1);

int[,] matrix2 = ArrayMatrixIntCreater(3, 3);
System.Console.WriteLine();
ArrayMatrixIntPrint(matrix2);

int[,] matrixM = MatrixMultiple(matrix1, matrix2);
System.Console.WriteLine();
ArrayMatrixIntPrint(matrixM);
