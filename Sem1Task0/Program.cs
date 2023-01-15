// Напишите программу, которая на вход принимает число и 
// выдаёт его квадрат (число умноженное на само себя).

// считываем данные с консоли
string? inputNum = Console.ReadLine();
// Проверяем, чтобы данные были не пустыми
if(inputNum!=null)
{
//   Парсим введенное число 
// int number = int.Parse(inputNum);

//    int result = number * number;

//    Console.WriteLine(result);

    Console.WriteLine(Math.Pow(int.Parse(inputNum), 2));

}
