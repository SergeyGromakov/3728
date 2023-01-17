//вводим 1 и второе число
Console.Write("Введите первое чило: ");
string? inputNum1 = Console.ReadLine();
Console.Write("Введите второе чило: ");
string? inputNum2 = Console.ReadLine();
if (inputNum1!= null && inputNum2!= null)
{
//Парсим значения 
int number1 = int.Parse(inputNum1);
int number2 = int.Parse(inputNum2);
Console.Write("Больше число ");
//  Через функцию "если условие...в другом случае..." выводим большее число на экран
if (number1 > number2)
{
    Console.WriteLine(number1);
}
else
{
    Console.WriteLine(number2);
}
}