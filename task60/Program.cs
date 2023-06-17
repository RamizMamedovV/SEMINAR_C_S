// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)

int[,,] Matrix3DIntCreater(int depth, int rows, int columns, int minVal = 10, int maxVal = 99)
{
    int[,,] mtx = new int[depth, rows, columns];

    for (int i = 0; i < mtx.GetLength(0); i++)
    {
        for (int j = 0; j < mtx.GetLength(1); j++)
        {
            for (int k = 0; k < mtx.GetLength(2); k++)
            {
                mtx[i, j, k] = minVal++;
            }
        }
    }

    return mtx;
}

void ArrayMatrixIntPrint(int[,,] mtx)
{
    for (int i = 0; i < mtx.GetLength(0); i++)
    {
        for (int j = 0; j < mtx.GetLength(1); j++)
        {
            for (int k = 0; k < mtx.GetLength(2); k++)
            {
                Console.Write($"{mtx[i, j, k],4}({i},{j},{k})");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] mart3D = Matrix3DIntCreater(3, 4, 5);

ArrayMatrixIntPrint(mart3D);
