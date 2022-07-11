int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
Console.WriteLine(Sum(a,b));

int Sum(int a, int b)
{
    if(b == a) return a;
    else
    {
       return a + Sum(a+1,b);
    }
}