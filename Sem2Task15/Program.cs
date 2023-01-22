
// Вариант 1
// Console.Write("Введите номер дня недели - ");
// int numberofday = int.Parse(Console.ReadLine() ?? "0");
// if ((numberofday > 0) && (numberofday < 8))
// {
//     if (numberofday > 5)
//     {
//         Console.WriteLine("Данный день является выходным");
//     }
//     else
//     {
//         Console.WriteLine("Данный день является рабочим");
//     }
// }
// else
// {
// Console.WriteLine("Не является днем недели");
// }

//вариант 2

Console.Write("Введите номер дня недели - ");
int numberofday = int.Parse(Console.ReadLine() ?? "0");
if ((numberofday > 0) && (numberofday < 8))
{
Dictionary<int, string> daysoftheweek = new Dictionary<int, string>();
    daysoftheweek.Add(1, "Понедельник, рабочий день");
    daysoftheweek.Add(2, "Вторник, рабочий день");
    daysoftheweek.Add(3, "Среда, рабочий день");
    daysoftheweek.Add(4, "Четверг, рабочий день");
    daysoftheweek.Add(5, "Пятница, рабочий день");
    daysoftheweek.Add(6, "Суббота, выходной день день");
    daysoftheweek.Add(7, "Воскресенье, выходной день день");
Console.WriteLine(daysoftheweek[numberofday]);
}
else
{
Console.WriteLine("Не является днем недели");
}

