Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Summa(num1, num2);
Console.WriteLine(Summa2(num1, num2) * 10);

// int sum = num1 + num2;
// Console.WriteLine(sum);

void Summa(int num1, int num2)
{
    int sum = num1 + num2;
    Console.WriteLine(sum);
}

int Summa2(int num1, int num2)
{
    int sum = num1 + num2;
    return sum;
}
