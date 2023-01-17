//вводим 1.2 и 3 число
Console.Write("Введите первое чило: ");
string? inputNum1 = Console.ReadLine();
Console.Write("Введите второе чило: ");
string? inputNum2 = Console.ReadLine();
Console.Write("Введите третье чило: ");
string? inputNum3 = Console.ReadLine();
if (inputNum1!= null && inputNum2!= null && inputNum3!= null)
{
//Парсим значения 
int number1 = int.Parse(inputNum1);
int number2 = int.Parse(inputNum2);
int number3 = int.Parse(inputNum3);
Console.Write("Большее число ");
// сравниваем числа 1 и 2 и затем внутри if создаем еще if, где сравниваем победителя с 3 числом
if (number1 > number2)
{
    if(number1>number3)
    { 
        Console.WriteLine(number1);
    }
    else
    {
        Console.WriteLine(number3);
    }
}
else
{
    if(number2>number3)
    { 
        Console.WriteLine(number2);
    }
    else
    {
        Console.WriteLine(number3);
    }
}
}