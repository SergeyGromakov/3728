// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит 
// информацию о том, сколько раз встречается элемент входных данных.

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

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int[] FillFreqDic(int[,] arr, int length)
{
    int[] fArray = new int[length];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            ++fArray[arr[i, j]];
        }
    }
    return fArray;
}

int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = Gen2DArray(m, n, 0, 100);
Print2DArr(matrix);
int[] freqDic = FillFreqDic(matrix, 101);
Print1DArr(freqDic);