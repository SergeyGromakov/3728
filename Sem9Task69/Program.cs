// Принимает а и б и возводит а в степень б

int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintResult(long prefix)
{
    Console.WriteLine(prefix);
}

long RecPowFlow(int a, int b)
{
    if(b<=1)return a;
    return a*RecPowFlow(a,b-1);
}

long MyPow(int a, int b)
{
    if(b==2)return a*a;
    return MyPow(a,b/2)*MyPow(a,b/2);
}

int numberA = ReadData("Enter number A:");
int numberB = ReadData("Enter number B:");
long res1 =0;
long res2 =0;
PrintResult(res1);
PrintResult(res2);
