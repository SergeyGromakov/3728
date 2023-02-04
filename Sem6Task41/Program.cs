// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//метод ввода с простым выводом сообщения пользователю
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//метод ввода с меняющимся выводом сообщения пользователю
int ReadData1(string msg, int i)
{
    Console.WriteLine(msg + " " + i);
    return int.Parse(Console.ReadLine() ?? "0");
}

// метод создания массива из значений, введенных пользователем 
int[] ArrayofNumbers(int num)
{
    int[] InputArray = new int[num];
    for (int i = 0; i < num; i++)
    {
        InputArray[i] = ReadData1("Ввежите число №", i + 1);
    }
    return InputArray;
}

// метод - счётчик положительных значений массива
void PositiveNumbers(int[] array)
{
    int count = 0;
    for(int i =0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine("Количество введенных числе больше 0: " + count);
}

int num = ReadData("Введите количество чисел, которое желаете ввести");
int[] array = ArrayofNumbers(num);
PositiveNumbers(array);