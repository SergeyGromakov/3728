// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в
// массиве.

// int[] Gen1DArr(int len, int minValue, int maxValue)
// {
//     Random rnd = new Random();
//     int[] arr = new int[len];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return arr;
// }

// void Print1DArr(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.WriteLine(arr[arr.Length - 1]+"]");
// }

// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// void PrintData(string msg, int res)
// {
//     Console.WriteLine(msg + res);
// }

// int Search(int[]arr, int e)
// {
//     int res = -1;
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         if(arr[i]==e);
//         res = i;
//         break;
//     }
//     return res;
// }

// int[] TestArray = Gen1DArr(12, -9, 9);
// Print1DArr(TestArray);
// int element = ReadData("Какой элемент найти? ");
// int result = Search(TestArray, element);

// if (result >= 0)
// {
//     PrintData("Элемент найден в позиции: ", (result+1));
// }
// else
// {
//     Console.WriteLine("В массиве элемент не найден!");
// }


int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

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

int Search(int[] arr, int e)
{
    int res = -1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == e)
        {
            res = i;
            break;
        }
    }
    return res;
}

int[] testArr = Gen1DArray(12, -9, 9);
Print1DArr(testArr);
int element = ReadData("Какой элемент найти?: ");
int result = Search(testArr, element);

if (result >= 0)
{
    PrintData("Элемент найден в позиции: " + (result+1));
}
else
{
    PrintData("В массиве элемент не найден!");
}
