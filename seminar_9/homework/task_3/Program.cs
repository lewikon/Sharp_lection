int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
Console.WriteLine(Accerman(m,n));

int Accerman(int m, int n)
{
    if (m == 0) return n+1;
    else if(m > 0 && n ==0)
    {
        return Accerman(m - 1, 1);
    }
    else
    {
        return Accerman(m-1, Accerman(m,n-1));
    }
}
