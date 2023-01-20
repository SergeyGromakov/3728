// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// int num = int.Parse(Console.ReadLine() ?? "0");
// int res1 = num % 7;
// int res2 = num % 23;
// if ((res1 == 0) && (res2 == 00))
// {
//     Console.WriteLine("Число кратно 23 и 7");
// }
// else
// {
//     Console.WriteLine("Число не кратно 23 и 7");
// }

Вариант 3

int num = int.Parse(Console.ReadLine() ?? "0");
if ((num % 7 == 0) && (num % 23 == 0))
{
    Console.WriteLine("кратное");
}
else
{
    Console.WriteLine("не кратное 7и и 23ём");
}