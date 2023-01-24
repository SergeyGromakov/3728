
// Метод ввода данных пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// проверяем является ли число палиндромом

bool PalinTest(int n)
{
    bool res = false;
    int d1 = n / 10000;
    int d2 = (n / 1000) % 10;
    int d3 = (n / 10) % 10;
    int d4 = n % 10;
    res = ((d1 == d4) && (d2 == d3)) ? true : false;
    return res;
}
// выводим результат на основании данных об истинности и сравниваем число
void PrintData(int num, bool res)
{
    if ((num > 9999) && (num < 100000))
    {
        if (res == true) Console.WriteLine("Введенное Вами число является палиндромом");
        if (res == false) Console.WriteLine("Введенное Вами число не является палиндромом");
    }
    else
    {
        Console.WriteLine("Введенное Вами число не является пятизначным");
    }
}

int FiveDigitsNumber = ReadData("Введите пятизначное число: ");
bool TrueOrFalse = PalinTest(FiveDigitsNumber);
PrintData(FiveDigitsNumber, TrueOrFalse);