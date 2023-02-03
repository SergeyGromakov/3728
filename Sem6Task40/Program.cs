// Напишите программу, которая принимает на вход
// три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void Result(int side1, int side2, int side3)
{
    if (side1 < side2 + side3 && side2 < side1 + side3 && side3 < side1 + side2)
    {
        Console.WriteLine("Является сторонами треугольника");
    }
    else
    {
        Console.WriteLine("Не является сторонами треугольника");
    }
}

int side1 = ReadData("Введите первую сторону");
int side2 = ReadData("Введите вторую сторону");
int side3 = ReadData("Введите третью сторону");
Result(side1, side2, side3);