// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 3D пространстве.
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// выводим результат пользователю
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

// Вычисляем расстояние между точками в 3D пространстве
double CalcLength(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double res = 0;
    res = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1-z2), 2));
    return res;
}
// Вводим координаты точек
int coordX1 = ReadData("Введите координату Х1");
int coordX2 = ReadData("Введите координату Х2");
int coordY1 = ReadData("Введите координату Y1");
int coordY2 = ReadData("Введите координату Y2");
int coordZ1 = ReadData("Введите координату Z1");
int coordZ2 = ReadData("Введите координату Z2");

// Вычисляем длину
double len = CalcLength(coordX1, coordX2, coordY1, coordY2, coordZ1, coordZ2);

// Выдаем результат

PrintData("Расстояние между точками равно ", len);
