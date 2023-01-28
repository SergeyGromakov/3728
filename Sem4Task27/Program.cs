// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в
// числе.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int Sum1(int num)
{
    int res = 0;
    while(num>0)
    {
        res = res + num%10;
        num = num/10;
    }
    return res;
}

// Второй метод через массив. Андрей, помогите пожалуйста, не могу понять почему у меня по отдельности машина читает цифры, 
// а в сумме выдает не их сумму... может с типом данных что-то?
int Sum2(int num)
{
    int res = 0;
    string digits = num.ToString();
    char[] DigitsArray = digits.ToCharArray();
    for(int i =0; i< DigitsArray.Length; i++)
    {
        Console.WriteLine(DigitsArray[i]);
        res = res + DigitsArray[i];
    }
    return res;
}

void PrintData(string msg, int res)
{
    Console.WriteLine(msg + res);
}

int number = ReadData("Введите любое число");
int FirstSum = Sum1(number);
int SecondSum = Sum2(number);
PrintData("Сумма первым методом: ", FirstSum);
PrintData("Сумма вторым методом: ", SecondSum);