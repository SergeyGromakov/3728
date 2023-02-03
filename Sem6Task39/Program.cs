// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.)
// Например:
// [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]
// Комментарий: эту задачу можно решить 2 способами: 1)
// менять числа местами в исходном массиве; 2) создать
// новый массив и в него записать перевёрнутый исходный
// массив по элементам.



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

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[] ConvertArray(int[] arr)
{
    int[] NewArray = new int[arr.Length];
    for(int i = 0; i < NewArray.Length; i++)
    {
        NewArray[i] = arr[arr.Length-1-i];
    }
    return NewArray;
}

int len = ReadData("Введите длину массива");
int minValue = ReadData("Введите минимальное значение элементов массива");
int maxValue = ReadData("Введите максимальное значение элементов массива");

int[] Array = Gen1DArray(len, minValue, maxValue);
Print1DArr(Array);
int[] NewArray = ConvertArray(Array);
Print1DArr(NewArray);