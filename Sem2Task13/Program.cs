// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Вариант 1
// Console.Write("Введите произвольное целое чило:  ");
// int number = int.Parse(Console.ReadLine() ?? "0");
// string Digits = number.ToString();
// char[] DigitsArray = Digits.ToCharArray();
// if(DigitsArray.Length>2)
// {
//     Console.WriteLine("Третья Цифра числа: " + DigitsArray[2]);
// }
// else
// {
//     Console.WriteLine("Третьей цифры в числе нет!");
// }

// Вариант 2

Console.Write("Введите произвольное целое чило:  ");
int number = int.Parse(Console.ReadLine() ?? "0");
// Ввожу дополнительную цифру, аналогичную введенной, чтобы ее использовать в счетчике, т.к. значение number 
// понадобится далее. Андрей, я помню, что как-то можно возвратить изначальное значение переменной, но за 1,5 часа
// я так и не смог вспомнить)))) 
int numberforcount = number;
int count = 0;
// делим число на 10 до тех пор, пока остаток от деления не станет равным 0 и каждое такое деление считаем. 
// Сумма делений = кол-во цифр
while (numberforcount > 0)
{
    numberforcount = numberforcount / 10;
    count++;
}
Console.WriteLine("Введенное число состоит из " + count + " цифр");

if (count > 3)
{   int number1 = number / (int)Math.Pow(10, count - 3);
    number1 = number1 % 10;
    Console.WriteLine("Третья цифра в числе - " + number1);
}
else
{
    if (count == 3) 
    {
        int number1 = number % 10;
        Console.WriteLine("Третья цифра в числе - " + number1);
    }
    else
    {
        Console.WriteLine("Третьей цифры в числе нет!");
    }
}