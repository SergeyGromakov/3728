//вводим 1.2 и 3 число
Console.Write("Введите первое чило: ");
string? inputNum1 = Console.ReadLine();
Console.Write("Введите второе чило: ");
string? inputNum2 = Console.ReadLine();
Console.Write("Введите третье чило: ");
string? inputNum3 = Console.ReadLine();
//Парсим значения 
int number1 = int.Parse(inputNum1);
int number2 = int.Parse(inputNum2);
int number3 = int.Parse(inputNum3);
Console.Write("Большее число ");
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