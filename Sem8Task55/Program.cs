// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//  В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Gen2DArray(int countRow, int countColumn, int minValue, int maxValue)
{
    int[,] outArray = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            outArray[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return outArray;
}

void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}

void TransArray(int[,] matr)
{
    int k = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = i + 1; j < matr.GetLength(1); j++)
        {
            k = matr[i, j];
            matr[i, j] = matr[j, i];
            matr[j, i] = k;
        }
    }
}

bool TestArray(int[,] arr)
{
    if (arr.GetLength(0) == arr.GetLength(1))
    {
        return true;
    }
    else
    {
        Console.WriteLine("Матрицу перевернуть нельзя!");
        return false;
    }
}


int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = Gen2DArray(m, n, 0, 100);
Print2DArr(matrix);
Console.WriteLine();

if (TestArray(matrix))
{
    TransArray(matrix);
    Print2DArr(matrix);
}
