Console.WriteLine("Введите координату по x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату по y");
int y = Convert.ToInt32(Console.ReadLine());
if( x  == 0 &&  y == 0)
{
    Console.WriteLine("x и y не могут быть равны нулю");
    return;
}
int result = FindNumberQuarter(x,y);
Console.WriteLine($"Номер четверти:{result}");

int FindNumberQuarter(int x, int y)
{
    int result = 0;
if( x > 0 && y > 0)
{
   result = 1;
}
if( x < 0 && y < 0)
{
    result = 3;
}
if( x > 0 && y < 0)
{
    result = 4;
}
if( x < 0 && y > 0)
{
    result = 2;
}
return result;
}