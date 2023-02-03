// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.


int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

string DoubleArray(int num)
{
    string result = string.Empty;
    while (num > 0)
    {
        result = Convert.ToString(num % 2) + result;
        num = num / 2;
    }
    return result;
}

int num = ReadData("Введите число");
string Result = DoubleArray(num);
Console.WriteLine(Result);