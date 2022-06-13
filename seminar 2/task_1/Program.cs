int GetRandomNumber()
{
    return new Random().Next(10, 1000);
}
int FindMaxDigit(int number)
{
int max = int.MinValue;
while(number >  0)
{
    int lastDigit = number % 10;
    if(lastDigit > max)
    {
        max = lastDigit;
    }
    number = number / 10;
}
return max;
}

int number = GetRandomNumber();
int maxDigit = FindMaxDigit(number);

Console.WriteLine(number);
Console.WriteLine(maxDigit);