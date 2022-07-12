int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int count = int.Parse(Console.ReadLine());
Console.WriteLine(Sum(a,b,count));


string Sum(int a, int b, int count)
{
    if(count == 0) 
    {
        return b + "";
    }
    else
    {
        return a + "," + Sum(b, a+b, --count);
    }
}