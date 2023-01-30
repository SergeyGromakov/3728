
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

int SumElem(int[] arr)
{
    int res = 0;
    // Андрей, тут я все-таки поставил 0, т.к. для пользователя 1 элемент и есть нечетная поз., для нас же это инд. 0
    for (int i = 0; i < arr.Length; i=i+2)
    {
        res = res + arr[i];
    }
    return res;
}

void PrintData(string msg, int res)
{
    Console.WriteLine(msg + " " + res);
}

// генерируем массив
int[] newArray = Gen1DArray(12, -9, 9);
// выводим массив на печать
Print1DArr(newArray);
// считаем сумму элементов с нечетным индексом
int sumOfElem = SumElem(newArray);
// выводим на экран результат
PrintData("Сумма элементов в  нечетной позиции ", sumOfElem);
