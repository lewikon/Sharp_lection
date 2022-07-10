int number = int.Parse(Console.ReadLine());
Console.WriteLine(NaturalNumber(number));

int NaturalNumber (int number)
{
    if(number ==1) return number;
    else 
    {
        Console.Write($"{NaturalNumber(number -1)},");
        return number;
    }
}