// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел от 1 до
// N.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// выводим результат пользователю
void PrintData(string msg1, string msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

// вывод нахождения степени чисел от 1 до N
string LineBuilder(int n, int p)
{
    string s = "";
    for(int i=1; i <= n; i++)
    {
        s+= Math.Pow(i, p).ToString() + "  ";
    }
    return s;
}

int num = ReadData("Введите N  ");

// Собираем первую строчку
string line1 = LineBuilder (num, 1);
// Собираем вторую строчку
string line2 = LineBuilder (num, 2);

// Вывод данных 
PrintData (line1, line2);