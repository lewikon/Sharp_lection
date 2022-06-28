Console.WriteLine("Введите числа через запятую: ");
string? numbersFromUser = Console.ReadLine();
int negativeCount = 0;
int commaCount = 0;
int positiveNumbers = 0;
for(int i = 0; i < numbersFromUser.Length; i++)
{
    if(numbersFromUser[i] == '-') negativeCount++;
    if(numbersFromUser[i] == ',') commaCount++;
}
commaCount = commaCount + 1;
positiveNumbers = commaCount - negativeCount;
Console.WriteLine(positiveNumbers);