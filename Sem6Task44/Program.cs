// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[] Fibonacci(int num)
{
    int[] NewArray = new int[num];
    for(int i = 2; i < num; i++)
    {
        NewArray[0] = 0;
        NewArray[1] = 1;
        NewArray[i] = NewArray[i-1] + NewArray[i-2];
    } 
    return NewArray;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]+"]");
}


int num = ReadData("Введите число элементов");
int[] NewArray = Fibonacci(num);
Print1DArr(NewArray);