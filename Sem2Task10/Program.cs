// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// // Вариант 1
// Console.Write("Введите любое число от 100 до 999: ");
// int number = int.Parse(Console.ReadLine() ?? "0");
// if ((number < 100) || (number > 999))
// {
//     Console.WriteLine("Вы ввели неверное число");
// }
// else
// преобразуем тип int в string, чтобы разбить число на 3 цифры в виде массива и выводим второе чило массива в консоль
// {
//     string digits = number.ToString();
//     char[] DigitsArray = digits.ToCharArray();
//     Console.WriteLine("Вторая цифра введенного Вами числа это  " + DigitsArray[1]);
// }

// Вариант 2
Console.Write("Введите любое число от 100 до 999: ");
int number = int.Parse(Console.ReadLine() ?? "0");
if ((number < 100) || (number > 999))
{
    Console.WriteLine("Вы ввели неверное число");
}
else
{
    // делением на 10 введенного числа избавляемся от последней цифры, 
    // далее еще раз делим на 100 и остаток и есть вторая цифра
    int result = number / 10;
    result = result % 10;
    Console.WriteLine("Вторая цифра введенного Вами числа это  " + result);
}

