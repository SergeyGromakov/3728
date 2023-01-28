//Задача №30
//Напишите программу, которая задает массив из 8 элементов и выводит их на экран
//Ввести с клавиатуры диапозон значений элемнтов и длину массива

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[] Gen1DArr(int num, int begin, int end)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        // добавил к end 1 т.к. это полуотрезок, т.е. не включает последнее значение, вводимое пользователем
        arr[i] = rnd.Next(begin, end + 1);
    }
    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}

int arrLen = ReadData("Введите длину массива.");
int LowRang = ReadData("Введите нижнюю границу значений элементов массива");
int HighRang = ReadData("Введите верхнюю границу значений элементов массива");
int[] arr = Gen1DArr(arrLen, LowRang, HighRang);

Print1DArr(arr);
