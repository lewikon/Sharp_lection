int number = int.Parse(Console.ReadLine());
Reverse(Console.Write(NumbersLine(number)));

int NumbersLine (int number)
{
    if(number == 1) 
    return 1;
    else 
    {
        return NumbersLine(number - 1);
    }
}
Reverse(Console.ReadLine());
void Reverse (char[] line)
{   
    int i = 0;
    while(line[i] < line.Length/2)
    {
        char[] temp = new char[line.Length];
        if (line [i] = ',') continue;
        temp[i] = line[i];
        line[i] = line[line.Length-i-1];
        line[line.Length-i-1] = temp[i];
        i++;
    }
}