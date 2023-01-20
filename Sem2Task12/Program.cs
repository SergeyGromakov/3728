// Программа на вход 2 числа и выводить явл. 2ое число кратным первому.
// Если 2 число не кратно первому - выводим остаток от деления
int num1 = int.Parse(Console.ReadLine()??"0");
int num2 = int.Parse(Console.ReadLine()??"0");
int res = num2%num1;
if(res==0)
{
    Console.WriteLine("Число 2 является кратным 1му");
}
else
{
    Console.WriteLine("Число 2 не является кратным 1му, остаток от деления: " + res);
}