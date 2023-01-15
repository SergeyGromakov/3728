// Вариант 1
//Считываем данные с консоли
// string? inputLine = Console.ReadLine();
// // Проверяем, чтобы данные не были пустыми
// if(inputLine!=null)
// {
// // Создаем массив с днями недели
// string[] dayWeek = new string[7];
// dayWeek[0] = "понедельник";
// dayWeek[1] = "вторник";
// dayWeek[2] = "среда";
// dayWeek[3] = "четверг";
// dayWeek[4] = "пятница";
// dayWeek[5] = "суббота";
// dayWeek[6] = "воскресение";
// // Парсим введенное число
// int inputNumber = int.Parse(inputLine);
// // Находим название дня недели по введенному номеру
// string outDayofWeek = dayWeek[inputNumber-1];
// // Выводим данные в консоль
// Console.WriteLine(outDayofWeek);
// }

// Вариант 2
// string? imputLine = Console.ReadLine();
// int imputNumber = int.Parse(imputLine);
// string outDayOfWeek = string.Empty;
// switch (imputNumber)
// {
//     case 1: outDayOfWeek = "понедельник"; break;
//     case 2: outDayOfWeek = "вторник"; break;
//     case 3: outDayOfWeek = "среда"; break;
//     case 4: outDayOfWeek = "четверг"; break;
//     case 5: outDayOfWeek = "пятница"; break;
//     case 6: outDayOfWeek = "суббота"; break;
//     case 7: outDayOfWeek = "воскресенье"; break;
//     default: outDayOfWeek = "это не день недели!"; break;
// }
// Console.WriteLine(outDayOfWeek);

// Вариант 3
string? imputLine = Console.ReadLine();
int imputNumber = int.Parse(imputLine);
string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(imputNumber));
Console.WriteLine(outDayOfWeek);