// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.
using System.Numerics;

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Выводим результат пользователю
void PrintData(string msg1, BigInteger msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

BigInteger CalcFact(int num)
{
    BigInteger res = 1;
    for(int i = 1; i<= num; i++)
    {
        res=res*i;
    }
     return res;
}


int num = ReadData("Введите число n: ");
BigInteger fact = CalcFact(num);
PrintData("Факториал введенного числа: ", fact);
