// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] MatrixIntSpiralwardsCreater(int rows, int colomns)
{
    int[,] mtx = new int[rows, colomns];
    int stVal = 0;
    int finVal = rows * colomns;
    int count = 1;
    int iNum = 0;
    int jNum = -1;

    if (stVal <= finVal)
    {
        MatrixForwardsFill(mtx, iNum, jNum, count, stVal, finVal);
    }

    return mtx;
}

void MatrixIntPrint(int[,] mtx)
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

void MatrixForwardsFill(int[,] mtx, int iNumber, int jNumber, int countNum,
                                                         int startVal, int finalVal)
{
    int stVal = startVal;
    int finVal = finalVal;
    int count = countNum;
    int iNum = iNumber;
    int jNum = jNumber + 1;
    int jn = 0;

    if (stVal < finVal)
    {
        for (int j = jNum; j < mtx.GetLength(1) - count; j++)
        {
            mtx[iNum, j] = stVal++;
            jn = j;
        }
        MatrixDownwardsFill(mtx, iNum, jn, count, stVal, finVal);
    }

    else return;
}

void MatrixDownwardsFill(int[,] mtx, int iNumber, int jNumber, int countNum,
                                                         int startVal, int finalVal)
{
    int stVal = startVal;
    int finVal = finalVal;
    int count = countNum;
    int iNum = iNumber;
    int jNum = jNumber + 1;
    int iN = 0;

    if (stVal < finVal)
    {
        for (int i = iNum; i < mtx.GetLength(0) - count; i++)
        {
            mtx[i, jNum] = stVal++;
            iN = i;
        }
        MatrixBackwardsFill(mtx, iN, jNum, count, stVal, finVal);
    }

    else return;
}

void MatrixBackwardsFill(int[,] mtx, int iNumber, int jNumber, int countNum,
                                                         int startVal, int finalVal)
{
    int count = countNum;
    int stVal = startVal;
    int finVal = finalVal;
    int iNum = iNumber + 1;
    int jNum = jNumber;
    int jN = 0;

    if (stVal < finVal)
    {
        for (int j = jNum; j > count - 1; j--)
        {
            mtx[iNum, j] = stVal++;
            jN = j;
        }
        MatrixUpwarsdFill(mtx, iNum, jN, count, stVal, finVal);
    }

    else return;
}

void MatrixUpwarsdFill(int[,] mtx, int iNumber, int jNumber, int countNum,
                                                         int startVal, int finalVal)

{
    int count = countNum;
    int stVal = startVal;
    int finVal = finalVal;
    int iNum = iNumber;
    int jNum = jNumber - 1;
    int iN = 0;

    if (stVal < finVal)
    {
        for (int i = iNum; i > count - 1; i--)
        {
            mtx[i, jNum] = stVal++;
            iN = i;
        }
        count += 1;
        MatrixForwardsFill(mtx, iN, jNum, count, stVal, finVal);
    }

    else return;

}

int[,] matrix = MatrixIntSpiralwardsCreater(6, 8);
MatrixIntPrint(matrix);
