int Input(string output)
{
Console.Write(output);
return Convert.ToInt32(Console.ReadLine());
}
int number = Input("Введите пятизначное число:");
if(number < 10000 || number > 99999)
{
    Console.WriteLine("Введите пятизначное число");
    return;
}
int number5 = number % 10;
int number4 = (number / 10) % 10;
int number2 = (number / 1000) % 10;
int number1 = (number / 10000) % 10;
if(number5 == number1  && number2 == number4)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
