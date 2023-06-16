// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int[,] MatrixIntCreator(int rows, int columns, int minVal = 0, int maxVal = 10)
{
    int[,] arr = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(minVal, maxVal);
        }

    }
    return arr;
}

void MatrixIntPrint(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j],3}");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void ArrayIntPrint(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i],2}");
    }
    System.Console.WriteLine();
    System.Console.WriteLine();
}

int[] ReplaceMatrixToArray(int[,] mtx)
{
    int arrLength = mtx.Length;
    int[] arr = new int[mtx.Length];

    for (int i = 0; i < mtx.GetLength(0); i++)
    {
        for (int j = 0; j < mtx.GetLength(1); j++)
        {
            arr[--arrLength] = mtx[i, j];
        }
    }
    return arr;
}

void ValueCounter(int[] arr)
{
    int count = 1;
    int val = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (val == arr[i]) count++;
        else
        {
            System.Console.WriteLine($"Число {val} встречаетя {count} раз");
            val = arr[i];
            count = 1;
        }
    }
    System.Console.WriteLine($"Число {val} встречаетя {count} раз");
}

int[,] matrix = MatrixIntCreator(3, 4);
MatrixIntPrint(matrix);

int[] array = ReplaceMatrixToArray(matrix);
ArrayIntPrint(array);

Array.Sort(array);
ArrayIntPrint(array);
ValueCounter(array);
