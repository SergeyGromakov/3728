// Cформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[,,] Gen3DArray(int raw, int col, int zcol)
{
    int[,,] matr = new int[raw, col, zcol];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int z = 0; z < matr.GetLength(2); z++)
            {
                matr[i, j, z] = new Random().Next(10, 100);
            }
        }
    }
    return matr;
}

void Print3DArr(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                Console.Write(arr[i, j, z] + "(" + i + ", " + j + ", " + z + ")" + "\t");
            }
            Console.WriteLine();
        }
    }
}

int raw = ReadData("Введите число строк матрицы: ");
int col = ReadData("Введите число столбцов  матрицы: ");
int colz = ReadData("Введите число столбцов глубины матрицы: ");
int[,,] new3dArray = Gen3DArray(raw, col, colz);
Print3DArr(new3dArray);