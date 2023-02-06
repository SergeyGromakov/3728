// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.

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

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
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

void SearchElement(int[,] arr, int element)
{
    bool elementFind = false;
    for(int i=0; i<arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == element)
            {
                Console.WriteLine("Данный элемент найден в " + i + " строке, " + j + " столбце");
                elementFind = true;
            }
        }
    }
    if(elementFind == false)
    {
        Console.WriteLine("Такого элемента в матрице нет");
    }
}

// Генерируем массив 10*10 со значениями от 0 до 20
int[,] genArray = Fill2DArray(10, 10, 0, 20);
// Печатаем сгенерированный массив
Print2DArr(genArray);
// Запрашиваем у пользователя значение искомого элемента
int elementFind = ReadData("Какой элемент вы хотите найти?");
// Находим элемент(ы) и выдаем его координаты
SearchElement(genArray, elementFind);