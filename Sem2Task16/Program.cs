//Является ли 2 числа квадратом друг друга
// Вариант 1
// Console.Write("Введите число 1: ");
// int num1 = int.Parse(Console.ReadLine()??"0");
// Console.Write("Введите число 2: ");
// int num2 = int.Parse(Console.ReadLine()??"0");
// if(num2 == num1*num1)
// {
//     Console.WriteLine("Число 2 квадрат 1го");
// }
// else
// {
//     if (num1==num2*num2)
//     {
//        Console.WriteLine("Число 1 квадрат 2го"); 
//     }
//     else
//     {
//         Console.WriteLine("Числа не являются квадратами друг друга"); 
//     }
// }

// Вариант 2

Console.WriteLine("input yor nums: ");
// Вводим данные с консоли
int num1 = int.Parse(Console.ReadLine() ?? "0");// Ввод первого числа
int num2 = int.Parse(Console.ReadLine() ?? "0");// Ввод второго числа
//сравнение возведённого в квадрат числа с другим числом
TestSQRT(num1,num2);
TestSQRT(num2,num1);
void TestSQRT(int i, int j)
{
    if ((int)Math.Pow(i, 2) == j)
    {
        Console.WriteLine("да, число " + j + " является квадратом числа " + i);
    }
    else
    {
        Console.WriteLine("число " + j + " не является квадратом числа " + i);
    }
}
