// // Программа выводит Случайное трехзначное число и убирает вторую его цифру
// System.Random numSintezator = new System.Random();
// int number = numSintezator.Next(100, 1000);
// Console.WriteLine (number);
// int digit1 = number/100;
// int digit2 = number%10;
// Console.WriteLine (digit1 *10 + digit2);

// вариант 2
System.Random random = new System.Random();

int randomNumber = random.Next(100,1000);

Console.WriteLine("число: " + randomNumber);

string value = randomNumber.ToString();

char[] numberArray = value.ToCharArray();

Console.WriteLine(numberArray[0] + "" + numberArray[2]);