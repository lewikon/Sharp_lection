Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int accumulation = 1;
for(int i = 1; i <= number; i++)
{
    accumulation = accumulation * i;
}
Console.WriteLine(accumulation);