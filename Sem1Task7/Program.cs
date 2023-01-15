// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.

string? imputNumLine = Console.ReadLine();
// // Проверяем, чтобы данные не были пустыми
if (imputNumLine != null)
    {
    // // Парсим введенное число
    int imputNumLine2 = int.Parse(imputNumLine);
// Берем остаток от деления 10
int lastDigit = imputNumLine2 % 10;
Console.WriteLine(lastDigit);
    }