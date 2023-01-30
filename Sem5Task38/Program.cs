// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] Gen1DArray(int len, int minValue, int maxValue)
{
    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
    }
    return arr;
}

void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

void PrintData(string msg, double res)
{
    Console.WriteLine(msg + " " + res);
}

double MaxMinusMin(double[] arr)
{
    double res = 0;
    double max = double.MinValue;
    double min = double.MaxValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= max)
        {
            max = arr[i];
        }
        if(arr[i] <= min)
        {
            min = arr[i];
        }

    }
    res = max - min;
    return res;
}


double[] newArray = Gen1DArray(12, -9, 9);
Print1DArr(newArray);
double res = MaxMinusMin(newArray);
PrintData("Разница между максимумом и минусом равна  ", res);