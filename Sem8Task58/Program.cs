// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[,] Gen2DArray(int raw, int col, int min, int max)
{
    int[,] matr = new int[raw, col];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matr;
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

int[,] Multiplication(int[,] a, int[,] b)
{
    int[,] multArray = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                multArray[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return multArray;
}

int raw1 = ReadData("Введите число строк 1 матрицы: ");
int col1 = ReadData("Введите число столбцов 1 матрицы: ");
int raw2 = ReadData("Введите число строк 2 матрицы: ");
int col2 = ReadData("Введите число столбцов 2 матрицы: ");

if (col1 != raw2)
{
    Console.WriteLine("Матрицы нельзя перемножить");
}
else
{
    int minValue = ReadData("Введите минимальное значение элемента матриц: ");
    int maxValue = ReadData("Введите максимальное значение элемента матриц: ");
    int[,] array1 = Gen2DArray(raw1, col1, minValue, maxValue);
    int[,] array2 = Gen2DArray(raw2, col2, minValue, maxValue);
    Console.WriteLine("Первая Матрица");
    Print2DArr(array1);
    Console.WriteLine("Вторая Матрица");
    Print2DArr(array2);
    int[,] multArray = Multiplication(array1, array2);
    Console.WriteLine("Результат умножения матриц");
    Print2DArr(multArray);
}