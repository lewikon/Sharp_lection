int Input(string output)
{
Console.Write(output);
return Convert.ToInt32(Console.ReadLine());
}

int a = Input("Введите число:");
int b = Input("Введите число:");
int power = 1;
for(int i = 1; i <= b; i++)
{
    power = power*a;
}
Console.WriteLine(power);