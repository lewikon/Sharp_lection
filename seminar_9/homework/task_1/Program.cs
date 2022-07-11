int number = int.Parse(Console.ReadLine());
int firstNumber = 1;
Console.Write(NumbersLine(firstNumber));
int NumbersLine(int count)
{
    if (count == number)
        return count;
    else
    {
        Console.Write(NumbersLine(count + 1) + ",");
        return count;
    }
}