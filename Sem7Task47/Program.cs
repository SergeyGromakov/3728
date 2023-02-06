// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

double[,] Fill2DArray(int countRow, int countColumn, int minValue, int maxValue)
{
    double[,] outArray = new double[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            outArray[i, j] = Math.Round((new Random().Next(minValue, maxValue) + new Random().NextDouble()), 2);
        }
    }
    return outArray;
}

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

void Print2DArr(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(0,16));
            Console.Write(arr[i, j] + "\t");
            Console.ResetColor(); 
        }
        Console.WriteLine("");
    }
}
// считываем от пользователя исходные данные для массива
int countRow = ReadData("Введите число строк матрицы");
int countColumn = ReadData("Введите число столбцову матрицы");
int minValue = ReadData("Введите минимальное значение элементов матрицы");
int maxValue = ReadData("Введите максимальное значение элементов матрицы");
//инициируем массив с заданным кол-вом строк, столбцов, мин и макс значениями. Вещественный рандом с округлением 
// до 2 после запятой
double[,] newArray = Fill2DArray(countRow, countColumn, minValue, maxValue);
// выводим массив в печать. 
Print2DArr(newArray);