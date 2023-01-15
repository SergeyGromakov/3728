// Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.

//вводим данные с 1 числа и второго
string? inputNum1 = Console.ReadLine();
string? inputNum2 = Console.ReadLine();

if (inputNum1!= null && inputNum2!= null)
{
    int number1 = int.Parse(inputNum1);
    int number2 = int.Parse(inputNum2);

    if (number1 == number2 * number2)
    {
        Console.WriteLine("Первое число квадрат второго");
    }
    else
    {
        Console.WriteLine("Первое число не является квадратом второго");
    }
}
