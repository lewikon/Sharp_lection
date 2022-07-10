int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
Console.WriteLine(NaturalNumber(m,n));

int NaturalNumber (int m,int n)
{
    if(m == n) return m;
    else
    {
        Console.Write($"{NaturalNumber(m,n-1)},");
        return n;
    }
}