// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int minVal = 0, int maxVal = 10)
{
    int[,] mtx = new int[rows, columns];
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

void PrintMatrix(int[,] mtx)
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

int UserEnter(string str)
{
    System.Console.Write(str);
    int num = Convert.ToInt32(System.Console.ReadLine());

    return num;
}

bool isExist(int[,] mtx, int rowVal, int columnVal)
{
    return (mtx.GetLength(0) >= rowVal && rowVal >= 0 
                && mtx.GetLength(1) >= columnVal && columnVal >= 0) ? true : false;
}

int[,] matrix = CreateMatrixRndInt(3, 4);
PrintMatrix(matrix);
int row = UserEnter("Введите номер строки: ");
int column = UserEnter("Введите номер столбца: ");
System.Console.WriteLine();
Console.WriteLine(isExist(matrix, row, column) ? $"значение в массиве: {matrix[row, column]}"
                                :"Такого элемента в массиве нет");