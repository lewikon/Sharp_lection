Console.WriteLine("Введите номер дня недели:");
int day = Convert.ToInt32(Console.ReadLine());
if(day > 7 || day < 1)
{
    Console.WriteLine("в неделе семь дней");
}
else
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Это выходной");
    }
    else
    {
        Console.WriteLine("Это рабочий день");
    }
}