// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] Gen1DArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
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

void PrintData(string msg, int res)
{
    Console.WriteLine(msg + " " + res);
}

bool Test(int n)
{
    return (n%2 == 0);
}

int CountElem(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (Test(arr[i]))
        {
            res++;
        }
    }
    return res;
}

//генерируем массив из 12 элементов с 3х значными значениями каждого элемента
int[] RndArray = Gen1DArray(12, 100, 999);
//печатем массив для визуализации
Print1DArr(RndArray);
// считаем кол-во элементов, которые четные, т.е. делятся на 2 без остатка
int ResCalc = CountElem(RndArray);
// выводим результат на экран
PrintData("Количество четных элементов", ResCalc);
