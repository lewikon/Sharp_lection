int[] StringToNumbers(string input)
{
    int countNumbers = 1;
    for(int i = 0; i  < input.Length; i++)
    {
        if(input[i] == ',') countNumbers++;
    }
    int[] numbers = new int[countNumbers];
    int index = 0;
    for(int i = 0; i  < input.Length; i++)
    {
        string tempString = "";
        while(input[i] != ',')
        {
           if (i != input.Length - 1)
           {
            tempString += input[i].ToString();
            i++;
           }
           else
           {
            tempString += input[i].ToString();
            break;
           }
        }
        numbers[index] = Convert.ToInt32(tempString);
        index++;

    }
    return numbers;
}

Console.WriteLine("Введите числа через запятую:");
int[] numbers = StringToNumbers(Console.ReadLine());
int count = 0;
for(int i =  0; i < numbers.Length; i++)
{
    if(numbers[i] < 0) count++;
}
Console.WriteLine(count);






