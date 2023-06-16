// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

int[,] MatrixIntCreator(int rows, int columns, int minVal = 0, int maxVal = 10)
{
    int[,] mtx = new int[rows, columns];
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
            System.Console.Write($"{mtx[i, j],3}");
        }
        System.Console.WriteLine();
    }
}

int[,] MatrixChanger(int[,] mtx)
{
    int nRows = mtx.GetLength(0) - 1;
    int nColumns = mtx.GetLength(1) - 1;
    int[,] nMtx = new int[nRows, nColumns];

    int minVal = mtx[0, 0];
    int minRowIndex = 0;
    int minColIndex = 0;

    for (int i = 0; i < mtx.GetLength(0); i++)
    {
        for (int j = 0; j < mtx.GetLength(1); j++)
        {
            if (mtx[i, j] < minVal)
            {
                minVal = mtx[i, j];
                minRowIndex = i;
                minColIndex = j;
            }
        }
    }

    System.Console.WriteLine($"Мин. числа индексы: {minRowIndex}, {minColIndex}");

    int newI = 0;
    int newj = 0;
    for (int i = 0; i < mtx.GetLength(0); i++)
    {
        if (i != minRowIndex)
        {
            newj = 0;
            for (int j = 0; j < mtx.GetLength(1); j++)
            {
                if (j != minColIndex)
                {
                    nMtx[newI, newj] = mtx[i, j];
                    newj++;
                }
            }
            newI++;
        }
    }

    return nMtx;
}


int[,] matrix = MatrixIntCreator(4, 4);
MatrixIntPrint(matrix);

System.Console.WriteLine();
int[,] newMatrix = MatrixChanger(matrix);
MatrixIntPrint(newMatrix);
