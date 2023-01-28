// Напишите цикл, который принимает на вход два чила (А и В) и возводит
// число А в степень В.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Возводим в степень встроенной математической функцией. Результат возведения в степень не может быть равен 0, потому 
// то значение оставлю для обозначения, если степень не натуральное число
int DegreeResult1(int numberA, int numberB)
{
    int res = 0;
    if (numberB > 0) { res = (int)Math.Pow(numberA, numberB); }
    return res;
}

// ввозводим в степень логическим методом черех счётчик. Результат возведения в степень не может быть равен 0, потому 
// то значение оставлю для обозначения, если степень не натуральное число
int DegreeResult2(int numberA, int numberB)
{
    int res = 0;
    if (numberB > 0)
    {
        res = 1;
        while (numberB > 0)
        {
            res = res * numberA;
            numberB = numberB - 1;
        }
    }
    return res;
}

// выводим результат. Поскольку в расчетных методах 0 это ошибка, то учитываем это. 
void PrintData(int result)
{
    if (result == 0) { Console.WriteLine("Ошибка ввода данных"); }
    else { Console.WriteLine("Результат возведения в сетепень: " + result); }
}

int A = ReadData("Введите число А");
int B = ReadData("Введите число В (степень числа А)");

DateTime d1 = DateTime.Now;
int ResDegree1 = DegreeResult1(A, B);
Console.WriteLine(DateTime.Now - d1);
PrintData(ResDegree1);

DateTime d2 = DateTime.Now;
int ResDegree2 = DegreeResult2(A, B);
Console.WriteLine(DateTime.Now - d2);
PrintData(ResDegree2);

