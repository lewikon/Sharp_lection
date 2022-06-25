//кажда сторона треугольника меньше суммы двух других
Console.WriteLine("Введите первую сторону: ");
int firstSide = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону: ");
int secondSide = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону: ");
int thirdSide = Convert.ToInt32(Console.ReadLine());
if(firstSide < secondSide + thirdSide && secondSide < firstSide + thirdSide && thirdSide < firstSide +secondSide)
{
    Console.WriteLine("Такой треугольник существует");
}
else
{
    Console.WriteLine("Такой треугольник не существует");
}