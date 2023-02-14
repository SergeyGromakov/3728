// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 
// N до 1. Выполнить с помощью рекурсии.

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

string LineGenRec(int num)
{
    if (num <= 0)
    {
        return string.Empty;
    }
    return num + " " + LineGenRec(num - 1);
}
// запрашиваем число N
int num = ReadData("Введите число N: ");
// рекурсивно выстраиваем строчный ряд. Каждый раз уменьшая N на 1 добавляем полученную цифру в ряд string
string result = LineGenRec(num);
// выводим результат
PrintResult(result);