// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

// int[,] MatrixChangeRowsToColumns(int[,] mtx)
// {
//     int rows = mtx.GetLength(0);
//     int col = mtx.GetLength(1);

//     int[,] newMtx = new int[col, rows];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             newMtx[j, i] = mtx[i, j];
//         }
//     }
//     return newMtx;
// }

void MatrixChangeRowsToColumnsVoid(int[,] mtx)
{
    int rows = mtx.GetLength(0);
    int col = mtx.GetLength(1);
    int temp = 0;

    if (rows == col)
    {
        for (int i = 1; i < rows; i++)
        {
            for (int j = 0; j < i; j++)
            {
                // if (i != j)
                // {
                temp = mtx[i, j];
                mtx[i, j] = mtx[j, i];
                mtx[j, i] = temp;
                System.Console.WriteLine($"{i}; {j}");
                //    }
            }
        }
    }
    else System.Console.WriteLine("no way!");
}

int[,] matrix = MatrixIntCreator(4, 5);
MatrixIntPrint(matrix);
System.Console.WriteLine();

// 2й способ
// int[,] newMatrix = MatrixChangeRowsToColumns(matrix);
// MatrixIntPrint(newMatrix);
// System.Console.WriteLine();

// MatrixIntPrint(matrix);
// System.Console.WriteLine();
MatrixChangeRowsToColumnsVoid(matrix);
MatrixIntPrint(matrix);