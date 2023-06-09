﻿// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5  7    -2    -0,2
// 1   -3,3   8    -9,9
// 8    7,8  -7,1   9

double[,] MatrixRndIntCreater(int rows, int columns, int minElem = 0, int maxElem = 10)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * (maxElem - minElem) + minElem;
        }
    }
    return matrix;
}

void PrinterFormattedMatrix(double[,] matrix, int formatVal = 2)
{
    string str = "  {0:F" + formatVal + "} ";

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(str, matrix[i, j]);
        }
        Console.WriteLine();
    }
}

double[,] matrix = MatrixRndIntCreater(4, 4);
PrinterFormattedMatrix(matrix, 2);
