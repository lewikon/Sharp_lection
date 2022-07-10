int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
Console.WriteLine(Power(a,b));

int Power(int a, int b)
{
    if(b == 1) return a;
    else
    {
       return a * Power(a,b-1);
    }
}