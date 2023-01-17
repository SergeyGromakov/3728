//вводим число
Console.Write("Введите чиcло: ");
string? inputNum = Console.ReadLine();
if (inputNum != null)
{
    // Парсим значения 
    int number = int.Parse(inputNum);
    if (number % 2 == 0)
    {
        Console.WriteLine("Введенное число чётное");
    }
    else
    {
        Console.WriteLine("Введенное число не чётное");
    }
}