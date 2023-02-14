// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintResult(int prefix)
{
    Console.WriteLine(prefix);
}

int RecSumMN(int numM, int numN)
{
    if (numM >= numN)
    {
        return numM;
    }
    else
    {
        return numM + RecSumMN(numM + 1, numN);
    }
}

//вводим исвходные данные
int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");
//суммируем все элементы в ряду. Предварительно проверяем, чтобы первое число было меньше второго. 
// В противном случае меняем их местами
int result = numM < numN ? RecSumMN(numM, numN) : RecSumMN(numN, numM);
// выдаем результат
PrintResult(result);