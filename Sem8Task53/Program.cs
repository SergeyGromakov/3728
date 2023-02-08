// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю
// строку массива.

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

void SwapRaw2DArray(int[,] matr)
{
    int k = 0;

    for(int i =0; i<matr.GetLength(1);i++)
    {
        k=matr[0,i];
        matr[0,i]=matr[matr.GetLength(0)-1,i];
        matr[matr.GetLength(0)-1,i]=k;
    }
}

int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = Gen2DArray(m,n,0,100);
Print2DArr(matrix);
SwapRaw2DArray(matrix);
Console.WriteLine();
Print2DArr(matrix);