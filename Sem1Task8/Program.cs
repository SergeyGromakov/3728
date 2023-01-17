//вводим число
Console.Write("Введите чиcло: ");
string? inputNum = Console.ReadLine();
if (inputNum!= null)
{
    int number = int.Parse(inputNum);
    string result = string.Empty;
    for( int i=2; i<number; i=i+2)
    {
        result = result + i + ",";
    }
    if (number%2 == 0)
    {
        result = result + number;
    }
    Console.WriteLine(result);
}