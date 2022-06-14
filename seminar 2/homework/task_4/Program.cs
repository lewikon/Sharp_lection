Console.WriteLine("Введите первое число:");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondnumber = Convert.ToInt32(Console.ReadLine());
if(firstnumber * firstnumber == secondnumber)
{
    Console.WriteLine("Число " + secondnumber + " является квадратом " + firstnumber);
}
else if(secondnumber * secondnumber == firstnumber)
{
    Console.WriteLine("Число " + firstnumber + " является квадратом " + secondnumber);
}
else
{
    Console.WriteLine("Ни одно из чисел не является квадратом другого");
}