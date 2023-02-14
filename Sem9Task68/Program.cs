// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintResult(long prefix)
{
    Console.WriteLine(prefix);
}

int AckermannFunction(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    if (numberM != 0 && numberN == 0)
    {
        return AckermannFunction(numberM - 1, 1);
    }
    if (numberM > 0 && numberN > 0)
    {
        return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
    }
    return AckermannFunction(numberM, numberN);
}

// вводим исходные данные 
int numberM = ReadData("Введите начальное число M:");
int numberN = ReadData("Введите конечное число N:");
// если введенные данные больше 0, то вычисляем функцию и выводим на печать
if (numberM > 0 && numberN > 0)
{
    int result = AckermannFunction(numberM, numberN);
    PrintResult(result);
}
else
{
Console.WriteLine("Вы ввели отрицательное число");
}