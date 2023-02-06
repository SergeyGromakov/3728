// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// столбце

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Fill2DArray(int countRow, int countColumn, int minValue, int maxValue)
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

double[] MeanColumn(int[,] arr)
{
    double[] meanArray = new double[arr.GetLength(1)];
    for(int i = 0; i < arr.GetLength(1); i++)
    {
        for(int j = 0; j < arr.GetLength(0); j++)
        {
            meanArray[i] += arr[j, i]; 
        }
        meanArray[i] = Math.Round(meanArray[i]/arr.GetLength(0), 2);
    }
    return meanArray;
}

void Print1DArr(double[] arr)
{
        for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "\t");
    }
}

// запрашиваем размерность массива и диапазон элементов
int countRow = ReadData("Введите количество строк матрицы");
int countColumn = ReadData("Введите количество столбцов матрицы");
int minValue = ReadData("Введите минимальное значение элементов матрицы");
int maxValue = ReadData("Введите максимальное значение элементов матрицы");

// генерируем массив
int[,] Matrix = Fill2DArray(countRow, countColumn, minValue, maxValue);

// печатаем сгенерированный массив
Print2DArr(Matrix);

// создаем одномерный массив, каэжый элемент которого явл. средним арифметическим соотв. строки матрицы
double[] meanValues = MeanColumn(Matrix);

// отступаем строчку
Console.WriteLine();

// выводим на печать 
Print1DArr(meanValues);