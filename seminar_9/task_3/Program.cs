int num = int.Parse(Console.ReadLine());
Console.WriteLine(Num(num));

int Num(int num)
{
    if(num > 0)
    {
        return num % 10 + Num( num / 10);
    }
    return num;
}