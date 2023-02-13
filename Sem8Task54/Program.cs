// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

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

void Sort2DArray(int[,] arr)
{
    int[] bufArray = new int[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            bufArray[j] = arr[i, j];
        }
        for (int j = 0; j < bufArray.Length; j++)
        {
            int max = 0;
            for (int n = j + 1; n < bufArray.Length; n++)
            {
                if (bufArray[n] > bufArray[j])
                {
                    max = bufArray[n];
                    bufArray[n] = bufArray[j];
                    bufArray[j] = max;
                }
            }
        }
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = bufArray[j];
        }
    }

}

// вводим исходные данные 
int raw = ReadData("Введите число строк матрицы: ");
int col = ReadData("Введите число столбцов матрицы: ");
int minValue = ReadData("Введите минимальное значение элемента матрицы: ");
int maxValue = ReadData("Введите максимальное значение элемента матрицы: ");
// генерируем массив из данных
int[,] matrix = Gen2DArray(raw, col, minValue, maxValue);
// печатаем массив
Print2DArr(matrix);
//отступаем строку
Console.WriteLine();
// сортируем массив методом пузырька. 
Sort2DArray(matrix);
// выводим на экран отсорттрованный массив
Print2DArr(matrix);