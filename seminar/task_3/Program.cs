Console.Write("Введите меньшее число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите большее число:");
int square = Convert.ToInt32(Console.ReadLine());
int result = square / number;
if(number == result)
{
    Console.WriteLine("Число " + square + " является квадратом числа " + number);
}
else
{
    Console.WriteLine("Число " + square + " не является квадратом числа " + number);
}