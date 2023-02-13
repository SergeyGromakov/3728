//  Задайте прямоугольный двумерный массив. Напишите программу, 
//  которая будет находить строку с наименьшей суммой элементов.

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

(int min, int str) MinSum2DArray(int[,] arr)
{
    int min = int.MaxValue;
    int str = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int buf = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            buf += arr[i, j];
        }
        if (buf < min)
        {
            min = buf;
            str = i;
        }
    }
    return (min, str);
}

void PrintData(string msg, int res)
{
    Console.WriteLine(msg + res);
}

// вводим исходные данные 
int raw = ReadData("Введите число строк матрицы: ");
int col = ReadData("Введите число столбцов матрицы: ");
int minValue = ReadData("Введите минимальное значение элемента матрицы: ");
int maxValue = ReadData("Введите максимальное значение элемента матрицы: ");

// поскольку у нас прямоугольник
if (raw != col)
{
    // генерируем
    int[,] array = Gen2DArray(raw, col, minValue, maxValue);
    //печатаем
    Print2DArr(array);
    //высчитываем минимальную сумму по строке, возвращаем эту сумму и номер строки (инд +1)
    (int buf, int str) minSumElem = MinSum2DArray(array);
    PrintData("Минимальная сумма равна: ", minSumElem.buf);
    PrintData("Это строка: ", minSumElem.str + 1);
}
else
{
    Console.WriteLine("Матрица не прямоугольная");
}